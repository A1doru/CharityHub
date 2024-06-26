﻿using CharityHub.Shared;

namespace CharityHub.Models.Users
{
    internal class CharityOrganization : User
    {
        public CharityOrganization(int id, string name, string surname, string email, string password)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
            this.UserType = UserType.CharityOrgaisation;
        }

        public CharityOrganization(string name, string surname, string email, string password)
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
            this.UserType = UserType.CharityOrgaisation;
        }
    }
}