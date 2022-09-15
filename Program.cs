using System;

namespace CampusVarberg_InternetBank
{
    class Program
    {
        static void Main()
        {
            int numberofTries = 0;
            string[,] userCredentials = new string[5, 2] { {"Max273", "1234" }, {"Anas847", "1234" }, {"Reidar746", "1234" }, {"Kristian932", "1234" }, {"Tobias628", "1234" } };

            Console.WriteLine("Welcome to Internet Bank 3483 ");
            bool existingUser = false;
            do
            {
                
                Console.Write("Input Username: ");
                string userInput1 = Console.ReadLine();
                Console.Write("Input Password: ");
                string userInput2 = Console.ReadLine();

                for (int i = 0; i < userCredentials.GetLength(0); i++)
                {
                    if (userCredentials[i, 0] == userInput1 && userCredentials[i, 1] == userInput2)
                    {
                        existingUser = true;
                    }

                }
                numberofTries++;
            } while (numberofTries < 3 && existingUser != true);

            Console.WriteLine("You are Logged in to the bank ");
        }
    }
}
