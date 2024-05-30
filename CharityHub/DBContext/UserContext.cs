using CharityHub.Models.Users;
using System.ComponentModel.DataAnnotations;

namespace CharityHub.DBContext
{
    public class UserContext
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }

        public UserContext(User newUser)
        {
            Id = newUser.Id;
            Name = newUser.Name;
            Surname = newUser.Surname;
            Email = newUser.Email;
            Password = newUser.Password;
            Type = (newUser.UserType == Shared.UserType.Volunteer) ? "Volunteer" : "Charity Organization";
        }

        public UserContext(string password, string email)
        {
            Email = email;
            Password = password;
        }
    }
}