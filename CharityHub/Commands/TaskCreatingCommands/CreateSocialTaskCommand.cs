using CharityHub.Models.Tasks;
using CharityHub.Navigation;
using CharityHub.ViewModels.CreatingTaskViewModels;
using System.ComponentModel;

namespace CharityHub.Commands.TaskCreatingCommands
{
    public class CreateSocialTaskCommand : CommandBase
    {
        private NavigationStore _navigationStore;
        private CreatingSocialViewModel _creatingSocialViewModel;

        public CreateSocialTaskCommand(CreatingSocialViewModel creatingSocialViewModel, NavigationStore navigationStore)
        {
            _creatingSocialViewModel = creatingSocialViewModel;
            _navigationStore = navigationStore;

            _creatingSocialViewModel.PropertyChanged += OnPropertyChanged;
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_creatingSocialViewModel.Title) &&
                   !string.IsNullOrEmpty(_creatingSocialViewModel.Description) &&
                   !string.IsNullOrEmpty(_creatingSocialViewModel.Link) &&
                   _creatingSocialViewModel.DeadlineDate >= DateTime.Now &&
                   base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            ITaskFactory taskFactory = new Models.Tasks.TaskFactory();
            TaskManager taskManager = new TaskManager(taskFactory);
            var physicalActivityTask = taskManager.CreateSocialActivityTask(_creatingSocialViewModel.Title,
                _creatingSocialViewModel.Description,
                _creatingSocialViewModel.DeadlineDate,
                _creatingSocialViewModel.Link);

            _navigationStore.CurrentViewModel = new CreatingTaskSuccessViewModel(_navigationStore);
        }

        private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(CreatingSocialViewModel.Title) ||
                e.PropertyName == nameof(CreatingSocialViewModel.Description) ||
                e.PropertyName == nameof(CreatingSocialViewModel.Link) ||
                e.PropertyName == nameof(CreatingSocialViewModel.DeadlineDate))
            {
                OnCanExecuteChanged();
            }
        }
    }
}