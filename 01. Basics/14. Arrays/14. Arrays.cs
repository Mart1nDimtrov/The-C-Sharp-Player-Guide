/**
Copying an Array. Write code to create a copy of an array. First, start by creating an initial array. 
(You can use whatever type of data you want.) Let ’ s start with 10 items. Declare an array 
variable and assign it a new (yes, that means we’ll use the new keyword) array with 10 items in 
it. Use the things we’ve discussed to put some values in the array.
Now create a second array variable. Give it a new array with the same length as the first. Instead 
of using a number for this length, use the Length property to get the size of the original array.
Use a loop to read values from the original array and place them in the new array. Also, print out 
the contents of both arrays, to be sure everything copied correctly. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                firstArr[i] = i;
            }

            int[] secondArr = new int[firstArr.Length];

            for (int i = 0; i < 10; i++)
            {
                secondArr[i] = firstArr[i];
            }

            Console.WriteLine("First array: {0}", string.Join(", ", firstArr));
            Console.WriteLine("Second array: {0}", string.Join(", ", secondArr));
        }
    }
}
