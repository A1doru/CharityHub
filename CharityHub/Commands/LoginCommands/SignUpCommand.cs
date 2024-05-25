using CharityHub.Models.Users;
using CharityHub.ViewModels.AuthentificationViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityHub.Commands.LoginCommands
{
    class SignUpCommand : CommandBase
    {
        UserFactory _userFactory;
        SignUpViewModel _signUpViewModel;

        public SignUpCommand(SignUpViewModel signUpViewModel)
        {
            _signUpViewModel = signUpViewModel;
            _userFactory = new UserFactory();
        }


        public override void Execute(object? parameter)
        {
            _userFactory.CreateUser(_signUpViewModel.SelectedUserType, _signUpViewModel.Name, 
                _signUpViewModel.Surname, 
                _signUpViewModel.Email, 
                _signUpViewModel.Password);
        }
    }
}
