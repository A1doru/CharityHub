using CharityHub.Commands;
using CharityHub.Commands.LoginCommands;
using CharityHub.Navigation;
using System.Windows.Input;

namespace CharityHub.ViewModels.AuthentificationViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        private string _password;

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }


        public ICommand BackCommand { get; }
        public ICommand LoginCommand { get; }

        public LoginViewModel(NavigationStore navigationStore)
        {
            BackCommand = new NavigationCommand(navigationStore, 
                () => new WelcomeViewModel(navigationStore));
            LoginCommand = new LoginCommand(navigationStore, this);
        }
    }
}