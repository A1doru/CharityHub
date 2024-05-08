namespace CharityHub.Models.Users
{
    abstract class User()
    {
        //Methods to Get info about user
        internal abstract User GetUser();

        internal abstract User GetUser(string id);
    }
}
