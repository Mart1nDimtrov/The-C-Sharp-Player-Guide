using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Designing_and_Building_Classes.Classes
{
    public class Ball
    {
        private int size;
        public Color color { get; set; }

        private int timesThrown;

        public Ball(int size, params int[] colors)
        {
            this.Size = size;
            if (colors.Length == 3)
            {
                this.color = new Color(colors[0], colors[1], colors[2]);
            }
            else if (colors.Length == 4)
            {
                this.color = new Color(colors[0], colors[1], colors[2], colors[3]);
            }
            this.TimesThrown = 0;
        }

        public int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public int TimesThrown
        {
            get { return this.timesThrown; }
            set { this.timesThrown = value; }
        }

        public void Pop()
        {
            this.Size = 0;
        }

        public void Throw()
        {
            if(this.Size > 0)
            {
                this.TimesThrown++;
            }
            else
            {
                throw new ArgumentException("The ball has been popped!");
            }
        }

    }
}
