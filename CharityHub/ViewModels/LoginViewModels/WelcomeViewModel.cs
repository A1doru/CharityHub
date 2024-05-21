using System.Windows.Input;

namespace CharityHub.ViewModels.AuthentificationViewModels
{
    class WelcomeViewModel : ViewModelBase
    {

        ICommand Login { get; }
        ICommand SignUp { get; }

        public WelcomeViewModel()
        {
            
        }
    }
}
