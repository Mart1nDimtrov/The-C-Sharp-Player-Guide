/*
3D Vectors.  Make a Vector class like the one we’ve created here, but instead of just x and y, 
also add in z. You’ll need to add another property, and the constructor will be a little different. 
Add operators that do the following:
  Add two 3D vectors together. (1, 2, 3) + (3, 3, 3) should be (4, 5, 6).
  Subtract one 3D vector from another. (1, 2, 3) - (3, 3, 3) should be (-2, -1, 0).
  Negate a 3D vector. For example, using the negative sign on (2, 0, -4) should be (-2, 0, 4).
  Multiply a vector by a number (scalar) so (1, 2, 3) * 4 should be (4, 8, 12).
  Divide a vector by a number (scalar) so (2, 4, 6) / 2 should be (1, 2, 3).
Additionally, write some code to run some tests on your newly created 3D vector class and check 
to see if everything is working.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._3D_Vectors
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector operator -(Vector v2)
        {
            return new Vector(-v2.X, -v2.Y, -v2.Z);
        }

        public static Vector operator *(Vector v1, double scalar)
        {
            return new Vector(v1.X * scalar, v1.Y * scalar, v1.Z * scalar);
        }

        public static Vector operator /(Vector v1, double scalar)
        {
            return new Vector(v1.X / scalar, v1.Y / scalar, v1.Z / scalar);
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return ((v1.X == v2.X) && (v1.Y == v2.Y) && (v1.Z == v2.Z));
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }

    }
}
