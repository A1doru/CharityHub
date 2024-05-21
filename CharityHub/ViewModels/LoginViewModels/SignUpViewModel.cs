using CharityHub.Shared;
using System.Collections.ObjectModel;

namespace CharityHub.ViewModels.AuthentificationViewModels
{
    public class SignUpViewModel : ViewModelBase
    {
        public SignUpViewModel()
        {
            _userTypes = new ObservableCollection<UserType>
            {
                UserType.Admin,
                UserType.CharityOrgaisation,
                UserType.Volunteer
            };
        }

        private string _email;

        public string Email
        {
            get
            {
                return _email;
            }
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

        private string _surname;

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
                OnPropertyChanged(nameof(Surname));
            }
        }

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private ObservableCollection<UserType> _userTypes;

        public ObservableCollection<UserType> UserTypes
        {
            get
            {
                return _userTypes;
            }
            set
            {
                _userTypes = value;
                OnPropertyChanged(nameof(UserTypes));
            }
        }

        private UserType _selectedUserType;

        public UserType SelectedUserType
        {
            get
            {
                return _selectedUserType;
            }
            set
            {
                _selectedUserType = value;
                OnPropertyChanged(nameof(SelectedUserType));
            }
        }
    }
}