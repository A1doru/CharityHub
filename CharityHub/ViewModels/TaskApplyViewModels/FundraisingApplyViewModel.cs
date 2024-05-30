using CharityHub.Commands;
using CharityHub.Commands.TaskListingCommands;
using CharityHub.DBContext;
using CharityHub.Navigation;
using CharityHub.ViewModels.TaskListingViewModels;
using System.Windows.Input;

namespace CharityHub.ViewModels.TaskApplyViewModels
{
    public class FundraisingApplyViewModel : ViewModelBase
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
        public string BankId
        {
            get
            {
                return _selectedTask.BankId;
            }
        }

        public string SumAmount
        {
            get
            {
                return $"{_selectedTask.SumAmount} UAH";
            }
        }

        public ICommand ApplyCommand { get; }
        public ICommand BackCommand { get; }

        public FundraisingApplyViewModel(TaskContext selectedTask, NavigationStore navigationStore)
        {
            _selectedTask = selectedTask;
            ApplyCommand = new ApplyCommand(navigationStore);
            BackCommand = new NavigationCommand(navigationStore, () => new TaskListingViewModel(navigationStore));
        }
    }
}
