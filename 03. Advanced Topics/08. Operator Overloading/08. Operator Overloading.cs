using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(5, 2);
            Vector b = new Vector(-3, 4);
            Vector result = a + b;   // We use the operator overload here.
            Console.WriteLine(result.X + result.Y);
            Console.ReadKey();
        }
    }
}
