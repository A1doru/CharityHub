using CharityHub.Models.Users;
using CharityHub.Navigation;
using CharityHub.ViewModels.AuthentificationViewModels;
using System.ComponentModel;

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
            _signUpViewModel.PropertyChanged += OnPropertyChanged;
        }


        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_signUpViewModel.Name) &&
                !string.IsNullOrEmpty(_signUpViewModel.Surname) &&
                !string.IsNullOrEmpty(_signUpViewModel.Email) &&
                !string.IsNullOrEmpty(_signUpViewModel.Password) &&
                base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            _userFactory.CreateUser(_signUpViewModel.SelectedUserType, _signUpViewModel.Name,
                _signUpViewModel.Surname,
                _signUpViewModel.Email,
                _signUpViewModel.Password);
            _navigationStore.CurrentViewModel = new LoginViewModel(_navigationStore);
        }

        private void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(_signUpViewModel.Name) ||
                e.PropertyName == nameof(_signUpViewModel.Surname) ||
                e.PropertyName == nameof(_signUpViewModel.Email) ||
                e.PropertyName == nameof(_signUpViewModel.Password))
            {
                OnCanExecuteChanged();
            }
        }
    }
}