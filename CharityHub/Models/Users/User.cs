using CharityHub.Shared;

namespace CharityHub.Models.Users
{
    abstract class User()
    {
        protected string Name { get; set; }
        protected string Email { get; set; }
        protected string Password { get; set; }
        public UserType Type { get; set; }
        protected DateTime CreatingDate { get; set; }

        //Methods to Get info about user
        public virtual User GetUser()
        {
            return this;
        }

        internal abstract User GetUser(string id);

        public override string ToString()
        {
            return $"My user is: {Name} {Email} {Password} {Type} {CreatingDate}";
        }

    }
}
