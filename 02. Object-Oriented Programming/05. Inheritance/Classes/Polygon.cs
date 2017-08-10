using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Inheritance.Classes
{
    public class Polygon
    {
        public int NumberOfSides { get; set; }

        public Polygon()
        {
            this.NumberOfSides = 0;
        }

        public Polygon(int numberOfSides)
        {
            this.NumberOfSides = numberOfSides;
        }
    }
}
