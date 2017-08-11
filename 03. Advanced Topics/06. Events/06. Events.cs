using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.PointChanged += HandlePointChanged;

            point.X = 3;
        }
        public static void HandlePointChanged(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("The point has been changed!");
        }
    }
}
