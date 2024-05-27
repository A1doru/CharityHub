using CharityHub.Commands.MainMenuCommands;
using CharityHub.Models.Users;
using CharityHub.Navigation;
using System.Windows.Input;

namespace CharityHub.ViewModels.MainMenuViewModels
{
    public class MainMenuVolunteerViewModel : ViewModelBase
    {
        public string Name
        {
            get
            {
                return UserSession.Instance.CurrentUser.Name;
            }
        }

        public string GreetingMessage
        {
            get
            {
                return $"Hello {Name}";
            }
        }

        private NavigationStore _navigationStore;

        public MainMenuVolunteerViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            TaskListingNavCommand = new TaskListingNavCommand();
        }

        public ICommand TaskListingNavCommand { get; }

    }
}
