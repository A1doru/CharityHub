using CharityHub.Navigation;

namespace CharityHub.ViewModels.MainMenuViewModels
{
    public class MainMenuVolunteerViewModel : ViewModelBase
    {
        private NavigationStore _navigationStore;

        public MainMenuVolunteerViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
    }
}
