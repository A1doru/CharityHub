using CharityHub.Commands;
using CharityHub.Navigation;
using CharityHub.ViewModels.MainMenuViewModels;
using System.Windows.Input;

namespace CharityHub.ViewModels.CreatingTaskViewModels
{
    public class CreatingTaskSuccessViewModel : ViewModelBase
    {
        private NavigationStore _navigationStore;
        private Models.Tasks.Task _newTask;

        public ICommand BackToMainMenuCommand { get; }

        public CreatingTaskSuccessViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            BackToMainMenuCommand = new NavigationCommand(navigationStore, () => new MainMenuCharityOrganizationViewModel(navigationStore));
        }
    }
}