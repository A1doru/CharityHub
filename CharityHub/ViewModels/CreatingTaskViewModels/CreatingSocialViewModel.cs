using CharityHub.Commands;
using CharityHub.Commands.TaskCreatingCommands;
using CharityHub.Navigation;
using System.Windows.Input;

namespace CharityHub.ViewModels.CreatingTaskViewModels
{
    public class CreatingSocialViewModel : ViewModelBase
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

        private string _link;

        public string Link
        {
            get
            {
                return _link;
            }
            set
            {
                _link = value;
                OnPropertyChanged(nameof(Link));
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
        public ICommand CreateSocialTaskCommand { get; }

        public CreatingSocialViewModel(NavigationStore navigationStore)
        {
            DeadlineDate = DateTime.Now;
            BackCommand = new NavigationCommand(navigationStore, () => new CreatingTaskBaseViewModel(navigationStore));
            CreateSocialTaskCommand = new CreateSocialTaskCommand(this, navigationStore);
        }
    }
}