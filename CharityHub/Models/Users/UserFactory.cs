using CharityHub.Shared;

namespace CharityHub.Models.Users
{
    class UserFactory
    {
        public User CreateUser(UserType userType)
        {
            if (userType == UserType.Admin)
            {
                return new Admin();
            }            
            else if (userType == UserType.Volunteer)
            {
                return new Volunteer();
            }            
            else if (userType == UserType.CharityOrgaisation)
            {
                return new CharityOrganization();
            }

            return null;
        }
    }
}
