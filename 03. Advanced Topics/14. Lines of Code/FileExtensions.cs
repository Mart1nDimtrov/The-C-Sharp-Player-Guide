using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _14.Lines_of_Code
{
    public static class FileExtensions
    {
        public static int CountLinesOfText(this string file)
        {
            int count = 0;
            foreach (string line in File.ReadLines(file))
            {
                count++;
            }
            return count;
        }

        public static int CountSourceCodeFiles(this string directory)
        {
            int count = 0;
            foreach (string line in Directory.EnumerateFiles(directory, "*.cs"))
            {
                count++;
            }
            return count;
        }
    }
}
