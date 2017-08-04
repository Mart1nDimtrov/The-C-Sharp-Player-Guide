/**
Making a Calculator. We’ re going to try making a program that is a calculator. This simple 
program is going to bring in much of everything else we’ve learned so far, so be ready for a 
challenge!
The program that we’ll make is going to be a simple calculator. We’ re going to ask the user to 
type in two numbers and then type in a math operation to perform on the two numbers.
Use a switch statement to handle the different operations in different ways.
Allow the user to type in ’+’ for addition, ’-’ for subtraction, ’*’ for multiplication, ’/’ for division, 
and ’%’ for remainder.
For bonus points, allow the user to type in ’^’ for a power. (You can compute this using 
Math.Pow.) For example, you can do x^2
by using the code below:
double result = Math.Pow(x, 2);
Print out the results for the user to see. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Making_a_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers and a sign for the operation you want to perform:");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());

            switch (sign)
            {
                case '+':
                    Console.WriteLine("The result is: {0}", first + second);
                    break;
                case '-':
                    Console.WriteLine("The result is: {0}", first - second);
                    break;
                case '*':
                    Console.WriteLine("The result is: {0}", first * second);
                    break;
                case '/':
                    Console.WriteLine("The result is: {0}", first / second);
                    break;
                case '%':
                    Console.WriteLine("The result is: {0}", first % second);
                    break;
                case '^':
                    Console.WriteLine("The result is: {0}", Math.Pow(first, second));
                    break;

                default:
                    break;
            }

        }
    }
}
