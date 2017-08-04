/*
Playing with Variables. Take the little piece of code above and make a program out of it. Follow 
the same steps you did in Chapter 3 when we made the Hello World program, but instead of 
adding code to print out “Hello World!”, add the lines above. Use Console.WriteLine, like we did 
before and print out the contents of the two variables. Before you run the code, think about 
what you expect to be printed out for the a and b variables. Go ahead and run the program. Is it 
what you expected?
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Playing_with_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;
            b = a;
            a = -3;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
