using CharityHub.ViewModels.AuthentificationViewModels;
using CharityHub.ViewModels.MainMenuViewModels;

namespace CharityHub.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel()
        {
            CurrentViewModel = new WelcomeViewModel();
        }
    }
}
