using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Inheritance.Classes
{
    public class Triangle : Polygon
    {
        public double PI { get; set; } = Math.PI;
        public Triangle() : base(3)
        {

        }
    }
}
