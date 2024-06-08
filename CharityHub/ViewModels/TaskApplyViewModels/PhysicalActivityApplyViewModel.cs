using CharityHub.Commands.TaskListingCommands;
using CharityHub.Commands;
using CharityHub.DBContext;
using CharityHub.Navigation;
using System.Windows.Input;
using CharityHub.ViewModels.TaskListingViewModels;

namespace CharityHub.ViewModels.TaskApplyViewModels
{
    public class PhysicalActivityApplyViewModel : ViewModelBase
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
        public string? DeadlineDate
        {
            get
            {
                return _selectedTask.DeadlineDate.ToString();
            }
        }
        public string Location
        {
            get
            {
                return _selectedTask.Location;
            }
        }

        private DateTime? _date;
        public DateTime? Date
        {
            get
            {
                return _selectedTask.Date;
            }
        }

        public ICommand ApplyCommand { get; }
        public ICommand BackCommand { get; }

        public PhysicalActivityApplyViewModel(TaskContext selectedTask, NavigationStore navigationStore)
        {
            _selectedTask = selectedTask;
            ApplyCommand = new ApplyCommand(navigationStore);
            BackCommand = new NavigationCommand(navigationStore, () => new TaskListingViewModel(navigationStore));
        }

    }
}
