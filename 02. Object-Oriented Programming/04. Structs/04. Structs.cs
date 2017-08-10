using _04.Structs.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeStruct time = new TimeStruct();
            time.Seconds = 10;
            UpdateTime(time);
            // Since struct is a value type Seconds won't change
            Console.WriteLine(time.Seconds);

            Wrapper wrapper = new Wrapper();
            wrapper.numbers = new int[3] { 10, 20, 30 };
            // The value in Wrapper is a reference type
            UpdateArray(wrapper);
            Console.WriteLine(wrapper.numbers[1]);

        }

        public static void UpdateTime(TimeStruct time)
        {
            time.Seconds++;
        }

        public static void UpdateArray(Wrapper wrapper)
        {
            wrapper.numbers[1] = 200;
        }
    }
}
