using CharityHub.Shared;
using System.ComponentModel.DataAnnotations;

namespace CharityHub.Models.Users
{
    public abstract class User()
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
    }
}