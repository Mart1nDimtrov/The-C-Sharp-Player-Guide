using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Inheritance.Classes
{
    public class Square : Polygon
    {
        public float Size { get; set; }

        public Square(float size)
        {
            this.Size = size;
            this.NumberOfSides = 4;
        }
    }
}
