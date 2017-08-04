/**
Totaling and Averaging Revisited. Earlier in this chapter, I presented code to go through an 
array and find the total or sum of all values in that array. I also presented code to average the 
values in an array. Using that code as a starting point, rewrite them to use foreach loops 
instead.
Also, answer this question: why can’t you use a foreach loop to copy one array to another, like 
we did in the last Try It Out! section? If you’ re struggling to find an answer, give it a try by coding 
it. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Totaling_and_Averaging_Revisited
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int total = 0;
            foreach (int num in array)
            {
                total += num;
            }
            float average = (float)total / array.Length;

            Console.WriteLine("Total: {0}", total);
            Console.WriteLine("Average: {0}", average);
        }
    }
}
