using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Polymorphism.SearchClasses
{
    public class RBsSearchEngine : SearchEngine
    {
        public override string[] Search(string findThis)
        {
            return new string[]
            {
                "I found something.",
                "I found this for you."
            };
        }
    }
}
