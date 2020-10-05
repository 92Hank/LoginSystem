using System;
using System.Collections.Generic;

namespace LoginSystem
{
    class Login
    {
        public void Menu()
        {
            // Skriv ut menyn
            Console.WriteLine("******facebook******");
            Console.WriteLine("[1] Login");
            Console.WriteLine("[2] Create an account");
            Console.WriteLine("[2] Clear all user");
            Console.WriteLine("[4] QUIT");
            Console.WriteLine("********************");
            Console.Write("Pick between 1-4: ");
            Console.WriteLine();
        }
        /// <summary>
        /// Frågar användaren om något
        /// </summary>
        /// <param name="question">En fråga</param>
        /// <returns>Texten användaren matat in</returns>
        public string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }


        /// <summary>
        /// Tar emot en okrypterad sträng och krypterar den
        /// </summary>
        /// <param name="okrypterad">Okrypterad sträng</param>
        /// <returns>Kryptyerad sträng</returns>
        public static string Kryptera(string okrypterad)
        {
            //Fyll i det här senare
            return "#" + okrypterad;
        }

        /// <summary>
        /// Tar emot en krypterad sträng och dekrypterar den
        /// </summary>
        /// <param name="krypterad">Krypterad sträng</param>
        /// <returns>Dekryptyerad sträng</returns>
        public string AvKryptera(string krypterad)
        {

            return krypterad.TrimStart('#');
        }

        /// <summary>
        /// Letar upp användare i databasen och kontrollerar namn/lösenord
        /// Kastar ett fel om användaren inte hittas
        /// </summary>
        /// <param name="name">Användarens namn</param>
        /// <param name="password">Användarens lösenord (okrypterat)</param>
        /// <returns>Användare om den hittas</returns>
        public User LoginUsers(string name, string password)
        {
            var allUsers = new List<User>();
            allUsers.Add(new User("Pär", Kryptera("nirvana20")));
            allUsers.Add(new User("Emmy", Kryptera("paris2020")));
            allUsers.Add(new User("Henke", Kryptera("tacos123")));
            allUsers.Add(new User("Patrik", Kryptera("kalleanka87")));

            var krypterat = Kryptera(password);

            foreach (var user in allUsers)
            {
                if (user.Name == name && user.Password == krypterat)
                {
                    return user;
                }
            }

            throw new Exception("Hittade inte användaren");
        }
    }
}