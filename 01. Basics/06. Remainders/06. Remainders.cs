using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Remainders
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine("{0}/{1} is {2} remainder {3}", a, b, quotient, remainder);
            Console.WriteLine("b * quotient + remainder is {0}", b * quotient + remainder);
        }
    }
}
