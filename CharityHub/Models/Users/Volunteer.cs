using CharityHub.Shared;

namespace CharityHub.Models.Users
{
    class Volunteer : User
    {
        public override User GetUser()
        {
            return this;
        }

        internal override User GetUser(string id)
        {
            throw new NotImplementedException();
        }

        public Volunteer(string name, string email, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.Type = UserType.Volunteer;
            this.CreatingDate = DateTime.Now;
        }
    }
}
