using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Error_Handling_and_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetUserNumber());
        }

        public static int GetUserNumber()
        {
            int userNumber = 0;

            while (userNumber < 1 || userNumber > 10)
            {
                try
                {
                    Console.WriteLine("Enter a number between 1 and 10:");
                    string userResponse = Console.ReadLine();
                    userNumber = Convert.ToInt32(userResponse);
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must enter a number.");

                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter a smaller number.");

                }
                catch (Exception)
                {
                    Console.WriteLine("An unknown error occured.");
                    
                }
    
            }

            return userNumber;
        }
    }
}
