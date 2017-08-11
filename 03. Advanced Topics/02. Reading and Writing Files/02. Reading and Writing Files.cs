using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reading_and_Writing_Files
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arrayOfInformation = new string[4];
            arrayOfInformation[0] = "This is line 1";
            arrayOfInformation[1] = "This is line 2";
            arrayOfInformation[2] = "This is line 3";
            arrayOfInformation[3] = "This is line 4";
            File.WriteAllLines(@"C:\Users\martin\Desktop\someText.txt", arrayOfInformation);

            string informationToWrite = "Hello persistent file storage world!";
            File.AppendAllText("C:\\Users\\martin\\Desktop\\someText.txt", informationToWrite);

            FileStream fileStream = File.OpenWrite("C:\\Users\\martin\\Desktop\\someText.txt");
            StreamWriter writer = new StreamWriter(fileStream);

            writer.Write(3);
            writer.Write("Hello");
            writer.Close();

            fileStream = File.OpenRead("C:\\Users\\martin\\Desktop\\someText.txt");
            StreamReader reader = new StreamReader(fileStream);
            char nextCharacter = (char)reader.Read();

            char[] bufferToPutStuffIn = new char[2];
            reader.Read(bufferToPutStuffIn, 0, 2);
            string whatWasReadIn = new string(bufferToPutStuffIn);
            string restOfLine = reader.ReadLine();
            string restOfText = reader.ReadToEnd();
            reader.Close();

            Console.WriteLine(whatWasReadIn);
            Console.WriteLine(restOfLine);
            Console.WriteLine(restOfText);

        }
    }
}
