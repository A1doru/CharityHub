using CharityHub.Navigation;

namespace CharityHub.ViewModels.MainMenuViewModels
{
    public class MainMenuCharityOrganizationViewModel : ViewModelBase
    {
        private NavigationStore _navigationStore;

        public MainMenuCharityOrganizationViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
    }
}
