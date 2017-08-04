/**
Positive or Negative? One thing that a lot of people have trouble with is doing multiplication 
when negative numbers are involved. They typically run into trouble when trying to figure out if 
the result should be positive or negative.
You’ re going to write a program to help them! But there’ s a catch. In this example, you’ re banned 
from actually doing the multiplication to figure out the answer. (It would be all too  easy to take 
two numbers and multiply them, and then check if the result is greater than or less than zero.) 
Instead, you will follow the same logic that a human has to follow to get your answer.
When you’ re multiplying two numbers together, if the two numbers have the same sign (both 
positive or both negative) the result is positive. If they have different signs, the result is negative.
Write a program that asks the user for two numbers and then, using the rule above, prints out 
whether the result should be positive or negative. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers:");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            if ((first < 0 && second < 0) || (first > 0 && second > 0))
            {
                Console.WriteLine("The product of the two numbers is positive.");
            }
            else
            {
                Console.WriteLine("The product of the two numbers is negative.");
            }

        }
    }
}
