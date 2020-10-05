using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Login displayMenu = new Login();
            UserInterface input = new UserInterface();

            var isRunning = true;

            while (isRunning)
            {

                Console.Clear(); //Clear program before next run

                displayMenu.Menu();

                try
                {
                    int menyVal = Convert.ToInt32(Console.ReadLine());


                    switch (menyVal)
                    {
                        // Login
                        case 1:
                            //Take user input
                            input.UserInput();
                            break;
                        case 2:
                            // Create account
                            break;
                        case 3:
                            // Clear all users
                            break;
                        case 4:
                            isRunning = false; // Quit
                            Console.WriteLine("The program ends here...");
                            Environment.Exit(-1);
                            break;
                        default:
                            Console.WriteLine("Wrong choice");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Wrong! Only numbers!");
                    Console.ReadLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}