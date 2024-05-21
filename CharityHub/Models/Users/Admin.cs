using CharityHub.Shared;

namespace CharityHub.Models.Users
{
    class Admin : User
    {
        public override User GetUser()
        {
            return this;
        }

        internal override User GetUser(string id)
        {
            throw new NotImplementedException();
        }

        public Admin(string name, string email, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.Type = UserType.Admin;
            this.CreatingDate = DateTime.Now;
        }
    }
}
