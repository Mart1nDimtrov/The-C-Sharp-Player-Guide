using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Using_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Hello World!");
            listOfStrings.Insert(0, "text3");
            string firstItem = listOfStrings.ElementAt(0);
            string secondItem = listOfStrings[1];
            listOfStrings.Clear();
            int itemsInList = listOfStrings.Count();

            List<int> someNumbersInAList = new List<int>() { 14, 24, 37 };


            Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            phoneBook["Gates, Bill"] = 5550100;
            phoneBook["Zuckerberg, Mark"] = 5551438;
            int billsNumber = phoneBook["Gates, Bill"];

        }
    }
}
