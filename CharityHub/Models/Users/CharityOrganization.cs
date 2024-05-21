using CharityHub.Shared;

namespace CharityHub.Models.Users
{
    class CharityOrganization : User
    {
        public override User GetUser()
        {
            return this;
        }

        internal override User GetUser(string id)
        {
            throw new NotImplementedException();
        }

        public CharityOrganization(string name, string email, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.Type = UserType.CharityOrgaisation;
            this.CreatingDate = DateTime.Now;
        }
    }
}
