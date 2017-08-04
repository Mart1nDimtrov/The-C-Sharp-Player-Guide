/*
Casting and Order of Operations. Using the above as an example, outline the process that will 
be done with the following statements:
double a = 1.0 + 1 + 1.0f;
int x = (int)(7 + 3.0 / 4.0 * 2);
Console.WriteLine( (1 + 1) / 2 * 3 );
If this is confusing, try putting the code into Visual Studio and running it. You can try breaking 
out parts of it into different lines and debug it if you want. (Chapter 44 discusses debugging in 
depth.) 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Casting_and_Order_of_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take a double, an int and a flot a parse them to double.
            double a = 1.0 + 1 + 1.0f;
            // 3.0 / 4.0 is 0.something, multiplied by to is almost one, plus 7 
            // is rounded into 8 when parsed into an int.
            int x = (int)(7 + 3.0 / 4.0 * 2);
            // Follows the PEMDAS rule.
            Console.WriteLine((1 + 1) / 2 * 3);
        }
    }
}
