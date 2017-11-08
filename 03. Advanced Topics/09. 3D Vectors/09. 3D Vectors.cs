using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._3D_Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(1, 2, 3);
            Vector b = new Vector(3, 3, 3);
            Vector added =  a + b;
            Console.WriteLine("X: {0}, Y: {1}, Z: {2}", added.X, added.Y, added.Z);
            Vector sub = a - b;
            Console.WriteLine("X: {0}, Y: {1}, Z: {2}", sub.X, sub.Y, sub.Z);
            Vector multiplied = a * 2;
            Console.WriteLine("X: {0}, Y: {1}, Z: {2}", multiplied.X, multiplied.Y, multiplied.Z);
            Vector divided = b / 2;
            Console.WriteLine("X: {0}, Y: {1}, Z: {2}", divided.X, divided.Y, divided.Z);
            Vector neg = -new Vector(2, 0, -4);
            Console.WriteLine("X: {0}, Y: {1}, Z: {2}", neg.X, neg.Y, neg.Z);
        }
    }
}
