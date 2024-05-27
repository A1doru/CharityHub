using CharityHub.Commands;
using CharityHub.Models.Users;
using CharityHub.Navigation;
using CharityHub.ViewModels.CreatingTaskViewModels;
using System.Windows.Input;

namespace CharityHub.ViewModels.MainMenuViewModels
{
    public class MainMenuCharityOrganizationViewModel : ViewModelBase
    {

        public string Name
        {
            get 
            {
                return UserSession.Instance.CurrentUser.Name;
                //return "Danyl";
            }
        }

        public string GreetingMessage
        {
            get
            {
                return $"Hello {Name}";
            }
        }


        public ICommand TaskCreatingNavCommand { get; }

        public MainMenuCharityOrganizationViewModel(NavigationStore navigationStore)
        {
            TaskCreatingNavCommand = new NavigationCommand(navigationStore, 
                () => new CreatingTaskBaseViewModel(navigationStore));
        }
    }
}
