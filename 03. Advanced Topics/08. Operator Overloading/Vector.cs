using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Operator_Overloading
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector (double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y); 
        }

        public static Vector operator -(Vector v2)
        {
            return new Vector(-v2.X, -v2.Y);
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return ((v1.X == v2.X) && (v1.Y == v2.Y));
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }
    }
}
