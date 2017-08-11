using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Delegates
{
    public delegate int MathDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            MathDelegate mathOperation = Add;
            int a = 7;
            int b = 6;

            Console.WriteLine(mathOperation(a,b));
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Power(int baseNumber, int exponent)
        {
            return (int)Math.Pow(baseNumber, exponent);
        }
    }
}
