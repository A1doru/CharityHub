using CharityHub.Navigation;
using CharityHub.ViewModels.AuthentificationViewModels;

namespace CharityHub.Commands.LoginCommands
{
    public class SignUpWelcomeCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public SignUpWelcomeCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }


        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new SignUpViewModel(_navigationStore);
        }
    }
}
