using _03.Designing_and_Building_Classes.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Designing_and_Building_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball ballOne = new Ball(20, 30, 20, 30);
            ballOne.Throw();
            Console.WriteLine(ballOne.TimesThrown);
            ballOne.Pop();
            Console.WriteLine(ballOne.Size);
            try
            {
                ballOne.Throw();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
