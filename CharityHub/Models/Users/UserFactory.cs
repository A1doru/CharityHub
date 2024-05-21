using CharityHub.Shared;

namespace CharityHub.Models.Users
{
    class UserFactory
    {
        public User CreateUser(UserType userType, string name, string email, string password)
        {
            if (userType == UserType.Admin)
            {
                return new Admin(name, email, password);
            }            
            else if (userType == UserType.Volunteer)
            {
                return new Volunteer(name, email, password);
            }            
            else if (userType == UserType.CharityOrgaisation)
            {
                return new CharityOrganization(name, email, password);
            }
            else
            {
                return null; //нужно будет создать обработчик ошибки
            }

        }
    }
}
