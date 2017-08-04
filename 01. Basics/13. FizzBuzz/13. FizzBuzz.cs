/**
FizzBuzz. We now know everything we need to be able to do a popular test problem in 
programming: the FizzBuzz problem. This is a simple little toy problem that many people who 
claim to know a particular programming language still seem to struggle with.
If you can complete this problem, you’ re probably better off than half of the other people in the 
world who claim to know C#. It’ s actually a sad state of affairs, because the problem is so simple, 
but even still, it is a fact than many people who claim to know C# (or another language) can’t 
even write this simple program in it. (Admittedly, they often don’t have Visual Studio and a 
compiler to check their work like you will, which makes the problem a bit harder.)
The challenge is to print out all of the numbers from 1 to 100. Except if a number is a multiple of 
3, print out the word “Fizz” instead. If the number is a multiple of 5, print out  “Buzz”. If a number 
is a multiple of both 3 and 5 (like 15 or 30) then print out  “FizzBuzz”.
A couple of things to remember that seem to derail people: Be sure you’ re going through the 
numbers 1-100, not 0-99, and you’ll likely use the remainder operator (%) which can be used to 
determine if something is a multiple of another number.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
