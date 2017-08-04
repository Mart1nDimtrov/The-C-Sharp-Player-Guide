/**
The Fibonacci Sequence. If you’ re up for a good challenge involving recursion, try out this 
challenge. The Fibonacci sequence is a sequence of numbers where the first two numbers are 1 
and 1, and every other number in the sequence after it is the sum of the two numbers before it. 
So the third number is 1 + 1, which is 2. The fourth number is the 2nd number plus the 3rd, 
which is 1 + 2. So the fourth number is 3. The 5th number is the 3rd number plus the 4th 
number: 2 + 3 = 5. This keeps going forever. 
The first few numbers of the Fibonacci sequence are: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...
Because one number is defined by the numbers before it, this sets up a perfect opportunity for 
using recursion.
Your mission, should you choose to accept it, is to create a method called Fibonacci, which 
takes in a number and returns that number of the Fibonacci sequence. So if someone calls 
Fibonacci(3), it would return the 3
rd
number in the Fibonacci sequence, which is 2. If someone 
calls Fibonacci(8), it would return 21.
In your Main method, write code to loop through the first 10 numbers of the Fibonacci 
sequence and print them out.
Hint #1: Start with your base case. We know that if it is the 1
st
or 2
nd
number, the value will be 1.
Hint #2: For every other item, how is it defined in terms of the numbers before it? Can you come 
up with an equation or formula that calls the Fibonacci method again?
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(5));
        }

        public static int Fibonacci(int num)
        {
            if (num == 1 || num == 2)
            {
                return 1;
            }
            return num + Fibonacci(num - 1); 
        }
    }
}
