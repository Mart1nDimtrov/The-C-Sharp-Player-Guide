using _07.Interfaces.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFileWriter textFileWriter = new TextFileWriter();
            textFileWriter.Write(@"C: \Users\martin\Desktop\text" + textFileWriter.Extension);
        }
    }
}
