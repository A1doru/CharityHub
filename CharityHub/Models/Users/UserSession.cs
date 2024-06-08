namespace CharityHub.Models.Users
{
    internal class UserSession
    {
        private static UserSession _instance;
        private static readonly object _lock = new object();

        public User CurrentUser { get; private set; }

        private UserSession()
        { }

        public static UserSession Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new UserSession();
                    }
                    return _instance;
                }
            }
        }

        public void SetUser(User user)
        {
            CurrentUser = user;
        }
    }
}