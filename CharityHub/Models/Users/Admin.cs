﻿namespace CharityHub.Models.Users
{
    class Admin : User
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