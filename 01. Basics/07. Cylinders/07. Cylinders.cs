/*
Cylinders: A Complete Program. We’ re going to create a simple program that will tell the user 
interesting information about a cylinder. A cylinder is usually defined by a height ( h) and radius 
of the base (r). Create a program that allows the user to type in these two values. We’ll do some 
math with those values to figure out the volume of that cylinder, as well as the surface area. 
(Don’t worry about the formulas; I’ll provide them to you.) The program will then output the 
results to the user.
The formula for the volume of a cylinder is this:
𝑉 =  𝜋r^2ℎ
The formula for the surface area of a cylinder is this:
𝑆𝐵 = 2𝜋𝑠(𝑠 + ℎ)
In both of these equations, r is the radius of the cylinder, h is the height of the cylinder, and of 
course, π≈ 3.1415926.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cylinders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height:");
            var height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the radius:");
            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine("The volume of the cylinder is: {0}", Math.PI * Math.Pow(radius, 2) * height);
            Console.WriteLine("The surface area of the cylinder is: {0}", 2 * Math.PI * radius * (radius + height));

        }
    }
}
