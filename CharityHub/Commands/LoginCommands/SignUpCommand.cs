using CharityHub.Models.Users;
using CharityHub.Navigation;
using CharityHub.ViewModels.AuthentificationViewModels;

namespace CharityHub.Commands.LoginCommands
{
    internal class SignUpCommand : CommandBase
    {
        private UserFactory _userFactory;
        private SignUpViewModel _signUpViewModel;
        private NavigationStore _navigationStore;

        public SignUpCommand(SignUpViewModel signUpViewModel, NavigationStore navigationStore)
        {
            _signUpViewModel = signUpViewModel;
            _userFactory = new UserFactory();
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _userFactory.CreateUser(_signUpViewModel.SelectedUserType, _signUpViewModel.Name,
                _signUpViewModel.Surname,
                _signUpViewModel.Email,
                _signUpViewModel.Password);
            _navigationStore.CurrentViewModel = new LoginViewModel(_navigationStore);
        }
    }
}