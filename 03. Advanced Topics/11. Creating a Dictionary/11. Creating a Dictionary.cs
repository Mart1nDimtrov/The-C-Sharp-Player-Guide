using System;
using System.Collections.Generic;
using System.Linq;
/*
Creating a Dictionary.  Create a class that is a dictionary, storing words (as a string) and their 
definition (also as a string). Use an indexer to allow users of the dictionary to add, modify, and 
retrieve definitions for words.
You should be able to add a word like this: dictionary["apple"] = "A particularly delicious 
pomaceous fruit of the genus Malus.";
You should be able to change a definition by reusing the same “key” word: dictionary["apple"] 
= "A fruit of the genus Malus that often times rots and is no longer delicious.";
You should also be able to retrieve a definition using the indexer: string definitionOfApple = 
dictionary["apple"];
Note that the .NET Framework already defines a Dictionary class, which uses generics and in 
the real world could be used to do what we’ re trying to do here, plus a whole lot more. But we’ re 
trying to get the hang of indexers here, so don’t use that class while doing this challenge.
*/
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
