/*
Area of a Triangle. Following the example above for calculating the area of a circle, create your 
own program that calculates the area of a triangle. The formula for this is:
𝐵 = 1/2 𝑐ℎ
A is the area of the triangle, b is the base of the triangle, and h is the height of the triangle.
You will want to create a variable in your program for each variable in the equation. Print out 
your results. Run through a few different values for b and h to make sure that it is working. For 
instance, check to make sure that if b is 5 and h is 6, the result is 15, and that if b is 1.5 and h is 4, 
you get 3.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Area_of_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base:");
            double baseOfTriangle = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height:");
            double heightOfTriangle = double.Parse(Console.ReadLine());

            Console.WriteLine("The area of the triangle is: {0}", 0.5 * baseOfTriangle * heightOfTriangle);


        }
    }
}
