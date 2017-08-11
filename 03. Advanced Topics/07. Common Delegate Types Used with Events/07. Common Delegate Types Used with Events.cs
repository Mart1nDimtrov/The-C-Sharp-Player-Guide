using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Common_Delegate_Types_Used_with_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberChangedEventArgs numbers = new NumberChangedEventArgs(5, 6);
            numbers.NumbersChanged += HandleNumberChanged;
            numbers.ChangeNumbers(6, 5);

        }
        public static void HandleNumberChanged(object sender, NumberChangedEventArgs args)
        {
            Console.WriteLine($"The value of first is now {args.First}.");
            Console.WriteLine($"The value of second is now {args.Second}.");
        }
    }
}
