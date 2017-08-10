using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Structs.Structs
{
        struct TimeStruct
        {
            private int seconds;

            public int Seconds
            {
                get { return this.seconds; }
                set { this.seconds = value; }
            }

            public int CalculateMinutes()
            {
                return this.seconds / 60;
            }
        }
}
