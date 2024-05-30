using CharityHub.Commands;
using CharityHub.Models.Users;
using CharityHub.Navigation;
using CharityHub.ViewModels.CreatingTaskViewModels;
using CharityHub.ViewModels.TaskListingViewModels;
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
            }
        }

        public string GreetingMessage
        {
            get
            {
                return $"Hello {Name}";
            }
        }

        public ICommand NavToOpenedTask { get; }
        public ICommand NavToClosedTask { get; }
        public ICommand TaskCreatingNavCommand { get; }

        public MainMenuCharityOrganizationViewModel(NavigationStore navigationStore)
        {
            TaskCreatingNavCommand = new NavigationCommand(navigationStore, 
                () => new CreatingTaskBaseViewModel(navigationStore));
            NavToOpenedTask = new NavigationCommand(navigationStore,
                () => new OrganizationTaskOpenedViewModel(navigationStore));
            NavToClosedTask = new NavigationCommand(navigationStore,
                () => new ClosedTaskListingViewModel(navigationStore));
        }
    }
}
