using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Methods_Revisited
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Average(2, 3));
            Console.WriteLine(Average(2, 5, 8));
            Console.WriteLine(Average(41, 49, 29, 2, -7, 18));
            int[] numbers = new int[5] { 5, 4, 3, 2, 1 };
            Console.WriteLine(Average(numbers));
        }
        public static double Average(params int[] numbers)
        {
            double total = 0.0;

            foreach (double number in numbers)
            {
                total += number;
            }
            return total / numbers.Length;
        }
    }
}
