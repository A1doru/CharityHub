namespace CharityHub.Models.Users
{
    class CharityOrganization : User
    {
        internal override User GetUser()
        {
            throw new NotImplementedException();
        }

        internal override User GetUser(string id)
        {
            throw new NotImplementedException();
        }
    }
}
