using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Polymorphism.SearchClasses
{
    public class SearchEngine
    {
        public virtual string[] Search(string findThis)
        {
            return new string[0];
        }
    }
}
