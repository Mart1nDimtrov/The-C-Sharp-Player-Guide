using _06.Polymorphism.SearchClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchEngine searchEngine1 = new SearchEngine();
            SearchEngine searchEngine2 = new GoogleSearch();
            SearchEngine searchEngine3 = new RBsSearchEngine();

        
            string[] defaultResults = searchEngine1.Search("hello");
            string[] googleResults = searchEngine2.Search("hello");
            string[] rbsResults = searchEngine3.Search("hello");


        }
    }
}
