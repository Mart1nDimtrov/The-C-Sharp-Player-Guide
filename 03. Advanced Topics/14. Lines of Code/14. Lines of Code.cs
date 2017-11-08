/*
Lines of Code.Going even further, let’ s make a program that will count the number of lines of
code a program has.
It is often interesting to know how big a particular program is. One way to measure this is in the
total lines of code it contains. (There is some debate about how useful this really is, but it is 
always fun to know and watch as your program grows larger.)
Create a simple program that, given a particular file, counts the number of lines of code it has.
For bonus points, ignore blank lines.
If you’ re up for a real big challenge, modify your program to start with a particular directory and
search it for all source code files (*.cs) and add them all up to see how big an entire project is. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Lines_of_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\martin\Desktop\The C# Player's Guide\03. Advanced Topics\14. Lines of Code\14. Lines of Code.cs";
            Console.WriteLine(filePath.CountLinesOfText());
            string directory = @"C:\Users\martin\Desktop\The C# Player's Guide\03. Advanced Topics\14. Lines of Code";
            Console.WriteLine(directory.CountSourceCodeFiles());
        }
    }
}
