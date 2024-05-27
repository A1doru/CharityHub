using CharityHub.Commands;
using CharityHub.Navigation;
using System.Windows.Input;

namespace CharityHub.ViewModels.AuthentificationViewModels
{
    class WelcomeViewModel : ViewModelBase
    {

        public ICommand LoginWelcome { get; }
        public ICommand SignUpWelcome { get; }

        public WelcomeViewModel(NavigationStore navigationStore)
        {
            LoginWelcome = new NavigationCommand(navigationStore, 
                () => new LoginViewModel(navigationStore));
            SignUpWelcome = new NavigationCommand(navigationStore, 
                () => new SignUpViewModel(navigationStore));
        }
    }
}