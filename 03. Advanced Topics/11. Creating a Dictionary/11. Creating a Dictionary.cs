using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Creating_a_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCustDict dictionary = new MyCustDict();

            dictionary["apple"] = "A particularly delicious pomaceous fruit of " +
                        "the genus Malus.";
            Console.WriteLine(dictionary["apple"]);

            dictionary["apple"] = "A fruit of the genus Malus that often times " +
                        "rots and is no longer delicious.";
            string definitionOfApple = dictionary["apple"];
            Console.WriteLine(definitionOfApple);

            Console.ReadKey();
        }
    }
}
