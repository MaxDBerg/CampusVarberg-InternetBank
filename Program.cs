using System;

namespace CampusVarberg_InternetBank
{
    class Program
    {
        
        static void Main()
        {
            string[,] userCredentials = new string[5, 2] { { "Max273", "1234" }, { "Anas847", "1234" }, { "Reidar746", "1234" }, { "Kristian932", "1234" }, { "Tobias628", "1234" } };

            bool userStatus = Login(userCredentials);

            if (userStatus == false)
            {
                return;
            } else if(userStatus == true)
            {
                Console.WriteLine("You are Logged in to the bank ");

            }

            do
            {
                MainMenu();

                Console.Write("Press 'Enter' to return to the main menu");
                
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }
        static bool Login(string[,] userInformation)
        {
            int numberofTries = 0;

            Console.WriteLine("Welcome to Internet Bank 3483 ");
            bool existingUser = false;
            do
            {
                
                Console.Write("Input Username: ");
                string userInput1 = Console.ReadLine();
                Console.Write("Input Password: ");
                string userInput2 = Console.ReadLine();

                for (int i = 0; i < userInformation.GetLength(0); i++)
                {
                    if (userInformation[i, 0] == userInput1 && userInformation[i, 1] == userInput2)
                    {
                        existingUser = true;
                    }

                }
                numberofTries++;
            } while (numberofTries < 3 && existingUser != true);
            return existingUser;
        }

        static void MainMenu()
        {
            Console.WriteLine("1 - View your accounts");
            Console.WriteLine("2 - Transfer between accounts");
            Console.WriteLine("3 - Take out money");
            Console.WriteLine("4 - Log out");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Accounts();
                    break;

                case 2:
                    Transfer();
                    break;

                case 3:
                    TakeOutMoney();
                    break;

                case 4:
                    LogOut();
                    break;

                default:
                    Console.WriteLine("Error: User Input out of bound");
                    break;
            }
        }
        static void Accounts()
        {

        }

        static void Transfer()
        {

        }

        static void TakeOutMoney()
        {

        }

        static void LogOut()
        {

        }
    }
}
