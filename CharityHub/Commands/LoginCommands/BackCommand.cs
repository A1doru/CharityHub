using CharityHub.Navigation;
using CharityHub.ViewModels.AuthentificationViewModels;

namespace CharityHub.Commands.LoginCommands
{
    public class BackCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public BackCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new WelcomeViewModel(_navigationStore);
        }
    }
}
