using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Designing_and_Building_Classes.Classes
{
    public class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public Color (int red, int green, int blue, int alpha)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = alpha;
        }

        public Color(int red, int green, int blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = 255;
        }

        public int Red
        {
            get { return this.red; }
            set { this.red = value; }
        }

        public int Green
        {
            get { return this.green; }
            set { this.green = value; }
        }

        public int Blue
        {
            get { return this.blue; }
            set { this.blue = value; }
        }

        public int Alpha
        {
            get { return this.alpha; }
            set { this.alpha = value; }
        }


        public int Grayscale()
        {
            return (this.Blue + this.Red + this.Green) / 3;
        }
    }
}
