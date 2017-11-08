using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Hello World!";
            string randomCaseTitle = title.ToRandomCase();
            Console.WriteLine(randomCaseTitle);
            Console.ReadKey();
        }
    }
}
