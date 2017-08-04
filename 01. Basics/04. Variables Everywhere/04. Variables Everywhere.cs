/*
Variables Everywhere. Create a new console application and in the Main method, create one 
variable of every type we’ve discussed here. That’ s 13 different variables. Assign each of them a 
value. Print out the value of each variable.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variables_Everywhere
{
    class Program
    {
        static void Main(string[] args)
        {
            byte zero = 0;
            short eleven = 11;
            int twelve = 12;
            long big = 2147483648;
            sbyte hundred = 100;
            ushort thousand = 1000;
            uint bigger = 2147483649;
            ulong biggerThanBig = 2147483650;
            char letter = 'z';
            string word = "self";
            float anotherPi = 3.1415926f;
            // the double uses twice as much bytes as the float to store digits
            double pi = 3.14159265358979323846;
            decimal number = 1.4596m;
            bool isTruth = false;

            Console.WriteLine(zero);
            Console.WriteLine(eleven);
            Console.WriteLine(twelve);
            Console.WriteLine(big);
            Console.WriteLine(hundred);
            Console.WriteLine(thousand);
            Console.WriteLine(bigger);
            Console.WriteLine(biggerThanBig);
            Console.WriteLine(letter);
            Console.WriteLine(word);
            Console.WriteLine(anotherPi);
            Console.WriteLine(pi);
            Console.WriteLine(number);
            Console.WriteLine(isTruth);

        }
    }
}
