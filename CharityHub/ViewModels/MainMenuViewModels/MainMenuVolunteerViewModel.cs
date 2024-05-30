using CharityHub.Commands;
using CharityHub.Models.Users;
using CharityHub.Navigation;
using CharityHub.ViewModels.TaskListingViewModels;
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

        public ICommand NavToActiveTask { get; }
        public ICommand NavToCompletedTask { get; }
        public ICommand TaskListingNavCommand { get; }

        public MainMenuVolunteerViewModel(NavigationStore navigationStore)
        {
            TaskListingNavCommand = new NavigationCommand(navigationStore, () => new TaskListingViewModel(navigationStore));
            NavToCompletedTask = new NavigationCommand(navigationStore, () => new CompletedTaskViewModel(navigationStore));
            NavToActiveTask = new NavigationCommand(navigationStore, () => new VolunteerTaskInProgressViewModel());
        }
    }
}
