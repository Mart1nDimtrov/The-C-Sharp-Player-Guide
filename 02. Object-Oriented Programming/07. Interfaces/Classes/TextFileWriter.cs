using _07.Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Interfaces.Classes
{
    public class TextFileWriter : IFileWriter
    {
        public string Extension { get { return ".txt"; } }

        public void Write(string filename)
        {
            string sentence = "This is some text.";
            System.IO.StreamWriter file =
            new System.IO.StreamWriter(filename);
            file.WriteLine(sentence);
            file.Close();
        }
    }
}
