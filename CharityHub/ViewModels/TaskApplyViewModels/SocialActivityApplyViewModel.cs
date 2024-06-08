using CharityHub.Commands.TaskListingCommands;
using CharityHub.Commands;
using CharityHub.DBContext;
using CharityHub.Navigation;
using System.Windows.Input;
using CharityHub.ViewModels.TaskListingViewModels;

namespace CharityHub.ViewModels.TaskApplyViewModels
{
    public class SocialActivityApplyViewModel : ViewModelBase
    {
        private TaskContext _selectedTask;

        public string Title
        {
            get
            {
                return _selectedTask.Title;
            }
        }
        public string Description
        {
            get
            {
                return _selectedTask.Description;
            }
        }
        public DateTime? DeadlineDate
        {
            get
            {
                return _selectedTask?.DeadlineDate;
            }
        }
        public string Link
        {
            get
            {
                return _selectedTask.SocialLink;
            }
        }

        public ICommand ApplyCommand { get; }

        public ICommand BackCommand { get; }

        public SocialActivityApplyViewModel(TaskContext selectedTask, NavigationStore navigationStore)
        {
            _selectedTask = selectedTask;
            ApplyCommand = new ApplyCommand(navigationStore);
            BackCommand = new NavigationCommand(navigationStore, () => new TaskListingViewModel(navigationStore));
        }
    }
}
