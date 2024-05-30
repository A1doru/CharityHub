using CharityHub.Models.Tasks;
using CharityHub.Navigation;
using CharityHub.ViewModels.CreatingTaskViewModels;
using System.ComponentModel;

namespace CharityHub.Commands.TaskCreatingCommands
{
    internal class CreatePhysicalTaskCommand : CommandBase
    {
        private CreatingPhysicalViewModel _creatingPhysicalViewModel;
        private NavigationStore _navigationStore;

        public CreatePhysicalTaskCommand(CreatingPhysicalViewModel creatingPhysicalViewModel, NavigationStore navigationStore)
        {
            _creatingPhysicalViewModel = creatingPhysicalViewModel;
            _navigationStore = navigationStore;

            _creatingPhysicalViewModel.PropertyChanged += OnPropertyChanged;
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_creatingPhysicalViewModel.Title) &&
                !string.IsNullOrEmpty(_creatingPhysicalViewModel.Description) &&
                !string.IsNullOrEmpty(_creatingPhysicalViewModel.Location) &&
                _creatingPhysicalViewModel.DeadlineDate >= _creatingPhysicalViewModel.Date &&
                base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            ITaskFactory taskFactory = new Models.Tasks.TaskFactory();
            TaskManager taskManager = new TaskManager(taskFactory);
            var physicalActivityTask = taskManager.CreatePhysicalActivityTask(_creatingPhysicalViewModel.Title,
                _creatingPhysicalViewModel.Description,
                _creatingPhysicalViewModel.DeadlineDate,
                _creatingPhysicalViewModel.Location,
                _creatingPhysicalViewModel.Date);

            _navigationStore.CurrentViewModel = new CreatingTaskSuccessViewModel(_navigationStore);
        }

        private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(CreatingPhysicalViewModel.Title) ||
                e.PropertyName == nameof(CreatingPhysicalViewModel.Description) ||
                e.PropertyName == nameof(CreatingPhysicalViewModel.Location) ||
                e.PropertyName == nameof(CreatingPhysicalViewModel.Date) ||
                e.PropertyName == nameof(CreatingPhysicalViewModel.DeadlineDate))
            {
                OnCanExecuteChanged();
            }
        }
    }
}