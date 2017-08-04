/**
Months of the Year. Using the DaysOfWeek enumeration as an example, create an 
enumeration to represent the months of the year. Assign them the values 1 through 12. Write a 
program to ask the user for a number between 1 and 12. Check to be sure that they gave you a 
value in the right range and use an explicit cast to convert the number to your month 
enumeration. Then, using a switch statement or if statement to print out the full name of the 
month they entered. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Enumerations
{
    enum MonthsOfYear
    {
        January = 1, February = 2, March = 3, April = 4,
        May = 5, June = 6, July = 7, August = 8,
        September = 9, October = 10, November = 11, December = 12
    };
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 12 or 0 to quit:");
            int number = int.Parse(Console.ReadLine());

            while (number != 0)
            {

                if (number >= 1 && number <= 12)
                {
                    Console.WriteLine((MonthsOfYear)number);
                }
                else
                {
                    Console.WriteLine("Invalid number.");
                }

                number = int.Parse(Console.ReadLine());
            }
           


        }
    }
}
