using CharityHub.Commands.LoginCommands;
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
            LoginWelcome = new LoginWelcomeCommand(navigationStore);
            SignUpWelcome = new SignUpWelcomeCommand(navigationStore);
        }
    }
}
