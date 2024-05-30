using CharityHub.Models.Tasks;
using CharityHub.Navigation;
using CharityHub.ViewModels.CreatingTaskViewModels;
using System.ComponentModel;

namespace CharityHub.Commands.TaskCreatingCommands
{
    public class CreateFundraisingTaskCommand : CommandBase
    {
        private NavigationStore _navigationStore;
        private CreatingFundraisingViewModel _creatingFundraisingViewModel;

        public CreateFundraisingTaskCommand(CreatingFundraisingViewModel creatingFundraisingViewModel, NavigationStore navigationStore)
        {
            _creatingFundraisingViewModel = creatingFundraisingViewModel;
            _navigationStore = navigationStore;

            _creatingFundraisingViewModel.PropertyChanged += OnPropertyChanged;
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_creatingFundraisingViewModel.Title) &&
                   !string.IsNullOrEmpty(_creatingFundraisingViewModel.Description) &&
                   !string.IsNullOrEmpty(_creatingFundraisingViewModel.BankId) &&
                   _creatingFundraisingViewModel.DeadlineDate >= DateTime.Now &&
                   base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            ITaskFactory taskFactory = new Models.Tasks.TaskFactory();
            TaskManager taskManager = new TaskManager(taskFactory);
            var socialActivity = taskManager.CreateFundraisingTask(_creatingFundraisingViewModel.Title,
                _creatingFundraisingViewModel.Description,
                _creatingFundraisingViewModel.DeadlineDate,
                _creatingFundraisingViewModel.BankId,
                int.Parse(_creatingFundraisingViewModel.SumAmount));

            _navigationStore.CurrentViewModel = new CreatingTaskSuccessViewModel(_navigationStore);
        }

        private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(CreatingFundraisingViewModel.Title) ||
                e.PropertyName == nameof(CreatingFundraisingViewModel.Description) ||
                e.PropertyName == nameof(CreatingFundraisingViewModel.SumAmount) ||
                e.PropertyName == nameof(CreatingFundraisingViewModel.BankId) ||
                e.PropertyName == nameof(CreatingFundraisingViewModel.DeadlineDate))
            {
                OnCanExecuteChanged();
            }
        }
    }
}