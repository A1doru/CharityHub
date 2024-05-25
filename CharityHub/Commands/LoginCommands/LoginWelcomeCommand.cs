using CharityHub.Navigation;
using CharityHub.ViewModels.AuthentificationViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityHub.Commands.LoginCommands
{
    public class LoginWelcomeCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public LoginWelcomeCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new LoginViewModel(_navigationStore);
        }
    }
}
