using CharityHub.DBContext;
using CharityHub.Shared;

namespace CharityHub.Models.Users
{
    internal class UserFactory
    {
        private UserContext newUserContext;
        private User newUser;

        public User CreateUser(UserType userType, string name, string surname, string email, string password)
        {
            if (userType == UserType.Volunteer)
            {
                newUser = new Volunteer(name, surname, email, password);
            }
            else if (userType == UserType.CharityOrgaisation)
            {
                newUser = new CharityOrganization(name, surname, email, password);
            }
            else
            {
                newUser = null;
            }

            newUserContext = new UserContext(newUser);

            using (var context = new CharityHubDbContext())
            {
                context.Users.Add(newUserContext);
                context.SaveChanges();
            }

            return newUser;
        }

        public User GetUser(UserType userType, UserContext userContext)
        {
            if (userType == UserType.Volunteer)
            {
                newUser = new Volunteer(userContext.Name, userContext.Surname,
                    userContext.Email, userContext.Password);
            }
            else if (userType == UserType.CharityOrgaisation)
            {
                newUser = new CharityOrganization(userContext.Name, userContext.Surname,
                    userContext.Email, userContext.Password);
            }
            else
            {
                newUser = null;
            }

            return newUser;
        }
    }
}