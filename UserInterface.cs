using System;
using System.Collections.Generic;

namespace LoginSystem
{
    class UserInterface
    {
        string name;
        Login newUser = new Login();

        public void UserInput()
        {
            //Take user input
            name = newUser.ReadString("Username: ");
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();
            string password = newUser.ReadString("Password: ");
            Console.WriteLine();

            User loginUser = new User(name, password);
            //Find user and login
            try
            {
                newUser.LoginUsers(name, password);
                Console.WriteLine($"{loginUser.Name} är nu inloggad");
            }
            catch (Exception ex)
            {
                //User does not exist
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        public void AddUsers()
        {

        }

        public void ClearUsers()
        {

        }
    }
}