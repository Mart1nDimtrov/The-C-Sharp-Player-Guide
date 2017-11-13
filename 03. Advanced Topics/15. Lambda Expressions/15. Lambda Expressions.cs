using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            Vector a = new Vector(1, 2, 3);
            Vector b = new Vector(5, 5, 5);
            Console.WriteLine((a+b).toString());
    }
    }
}
