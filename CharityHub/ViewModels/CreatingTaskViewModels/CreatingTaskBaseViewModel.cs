using CharityHub.Commands;
using CharityHub.Commands.TaskCreatingCommands;
using CharityHub.Navigation;
using CharityHub.Shared;
using CharityHub.ViewModels.MainMenuViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CharityHub.ViewModels.CreatingTaskViewModels
{
    internal class CreatingTaskBaseViewModel : ViewModelBase
    {
        private ObservableCollection<TaskType> _taskTypes;

        public ObservableCollection<TaskType> TaskTypes
        {
            get
            {
                return _taskTypes;
            }
            set
            {
                _taskTypes = value;
                OnPropertyChanged(nameof(TaskTypes));
            }
        }

        private TaskType _taskType;

        public TaskType TaskType
        {
            get
            {
                return _taskType;
            }
            set
            {
                _taskType = value;
                OnPropertyChanged(nameof(TaskType));
            }
        }

        public ICommand BackCommand { get; }
        public ICommand CreatingTaskSelectorCommand { get; }

        public CreatingTaskBaseViewModel(NavigationStore navigationStore)
        {
            _taskTypes = new ObservableCollection<TaskType>
            {
                TaskType.PhysicalActivity,
                TaskType.SocialActivity,
                TaskType.Fundraising
            };

            CreatingTaskSelectorCommand = new CreatingTaskSelectorCommand(this, navigationStore);
            BackCommand = new NavigationCommand(navigationStore, () => new MainMenuCharityOrganizationViewModel(navigationStore));
        }
    }
}