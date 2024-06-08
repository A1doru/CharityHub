using CharityHub.Commands;
using CharityHub.Commands.TaskCreatingCommands;
using CharityHub.Navigation;
using System.Windows.Input;

namespace CharityHub.ViewModels.CreatingTaskViewModels
{
    public class CreatingFundraisingViewModel : ViewModelBase
    {
        private string _title;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        private string _description;

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        private string _bankId;

        public string BankId
        {
            get
            {
                return _bankId;
            }
            set
            {
                _bankId = value;
                OnPropertyChanged(nameof(BankId));
            }
        }

        private string _sumAmount;

        public string SumAmount
        {
            get
            {
                return _sumAmount;
            }
            set
            {
                _sumAmount = value;
                OnPropertyChanged(nameof(SumAmount));
            }
        }

        private DateTime _deadlineDate;

        public DateTime DeadlineDate
        {
            get
            {
                return _deadlineDate;
            }
            set
            {
                _deadlineDate = value;
                OnPropertyChanged(nameof(DeadlineDate));
            }
        }

        public ICommand BackCommand { get; }
        public ICommand CreateFundraisingCommand { get; }

        public CreatingFundraisingViewModel(NavigationStore navigationStore)
        {
            _deadlineDate = DateTime.Now;
            BackCommand = new NavigationCommand(navigationStore, () => new CreatingTaskBaseViewModel(navigationStore));
            CreateFundraisingCommand = new CreateFundraisingTaskCommand(this, navigationStore);
        }
    }
}