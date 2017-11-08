using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Indexers
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double this[int index]
        {
            get
            {
                if (index == 0) { return X; }
                else if (index == 1) { return Y; }
                else { throw new IndexOutOfRangeException(); }
            }
            set
            {
                if (index == 0) { X = value; }
                else if (index == 1) { Y = value; }
                else { throw new IndexOutOfRangeException(); }
            }
        }

        public double this[string component]
        {
            get
            {
                if (component == "x") { return X; }
                if (component == "y") { return Y; }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (component == "x") { X = value; }
                if (component == "y") { Y = value; }
                throw new IndexOutOfRangeException();
            }
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
