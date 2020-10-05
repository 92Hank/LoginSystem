using System;
using System.Collections.Generic;

namespace LoginSystem
{
    class User
    {
        public string Name;
        public string Password;

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}