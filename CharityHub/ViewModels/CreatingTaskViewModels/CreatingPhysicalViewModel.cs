using CharityHub.Commands;
using CharityHub.Commands.TaskCreatingCommands;
using CharityHub.Navigation;
using System.Windows.Input;

namespace CharityHub.ViewModels.CreatingTaskViewModels
{
    class CreatingPhysicalViewModel : ViewModelBase
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

        private string _location;
        public string Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }

        public ICommand BackCommand { get; }
        public ICommand CreatePhysicalTaskCommand { get; }

        public CreatingPhysicalViewModel(NavigationStore navigationStore)
        {
            BackCommand = new NavigationCommand(navigationStore, () => new CreatingTaskBaseViewModel(navigationStore));
            CreatePhysicalTaskCommand = new CreatePhysicalTaskCommand();
        }
    }
}
