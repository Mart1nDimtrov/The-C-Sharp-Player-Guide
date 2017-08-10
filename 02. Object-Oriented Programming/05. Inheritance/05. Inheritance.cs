using _05.Inheritance.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Polygon polygon = new Square(4.5f);

            if (polygon is Square)
            {
                Square square = (Square)polygon;
            }

            Polygon anotherPolygon = new Square(4.5f);
            Square anotherSquare = polygon as Square;

            Polygon[] lotsOfPolygons = new Polygon[5];
            lotsOfPolygons[2] = new Square(2.1f);
            lotsOfPolygons[3] = new Triangle();

            Polygon yetAnotherPolygon = new Triangle();
            Triangle triangle = yetAnotherPolygon as Triangle;
            Console.WriteLine(triangle.PI);

            // any type of object can be stored in the object class
            object anyObject = triangle;

        }
    }
}
