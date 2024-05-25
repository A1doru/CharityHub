using CharityHub.DBContext;
using CharityHub.Models.Users;
using CharityHub.Navigation;
using CharityHub.ViewModels.AuthentificationViewModels;
using CharityHub.ViewModels.MainMenuViewModels;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace CharityHub.Commands.LoginCommands
{
    public class LoginCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        private CharityHubDbContext _context;
        private LoginViewModel _loginViewModel;


        public LoginCommand(NavigationStore navigationStore, LoginViewModel loginViewModel)
        {
            _navigationStore = navigationStore;
            _context = new CharityHubDbContext();
            _loginViewModel = loginViewModel;
        }

        public async override void Execute(object? parameter)
        {
            UserContext userContext = await ValidateUser();

            if (userContext == null)
            {
                MessageBox.Show("No such user exists");
            }
            else if(userContext.Type == "Volunteer")
            {
                //логика создания Singletone обьекта типа Volunteer
                _navigationStore.CurrentViewModel = new MainMenuVolunteerViewModel(_navigationStore);
            }
            else if(userContext.Type == "Charity Organization")
            {
                //логика создания Sigletone обьекта типа CharityOrganization
                _navigationStore.CurrentViewModel = new MainMenuCharityOrganizationViewModel(_navigationStore);
            }
        }   

        public async Task<UserContext> ValidateUser()
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Password == _loginViewModel.Password && u.Email == _loginViewModel.Email);
        }
    }
}
