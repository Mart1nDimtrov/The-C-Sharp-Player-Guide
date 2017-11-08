/*
Word Count.  Create an extension method for the string class that counts the total number of 
words in the string. You can make use of the Split method, which works like this: text.Split(' ');. 
This returns an array of strings, split up into pieces using the character passed in as the split 
point. 
For bonus points, take this a step further and split on all whitespace characters, including space 
(' '), the newline character ('\n'), the carriage return character ('\r'), the tab character ('\t'). For 
even more bonus points, ensure that words of length 0, don’t get counted.

Sentence and Paragraph Count.  Following the example of the Word Count problem above, 
create additional extension methods to count the number of sentences and paragraphs in a 
string. You can assume that a sentence is delimited (ended/separated) by the period ( ’. ’) symbol, 
and paragraphs are delimited with the carriage return symbol ('\n').
For tons of bonus points, put together a simple program that will read in a text file (see Chapter 
28) and print out the number of words, sentences, and paragraphs the file contains.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Count_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "What's the number of words?";
            Console.WriteLine(words.CountWordsInString());
            string sentences = "Get your computer set up and ready to begin making C# programs, and make your first C# program." + 
"Learn the basics of procedural programming in C#." + 
"Dig into object-oriented programming, from start to finish." +
"Cover some of the more advanced topics in C#, as well as common tasks that most programs need to use." +
"Learn how to use Visual Studio(or Visual Studio Express) and the tools that you need to make amazing software." +
"Try out your new skills against a variety of challenge problems, scattered throughout the book.";
            Console.WriteLine(sentences.CountSentencesInString());
            string pars = "Get your computer set up and ready to begin making C# programs, and make your first C# program." +
"Learn the basics of procedural programming in C#." +
"Dig into object-oriented programming, from start to finish." +
"Cover some of the more advanced topics in C#, as well as common tasks that most programs need to use.\n" +
"Learn how to use Visual Studio(or Visual Studio Express) and the tools that you need to make amazing software." +
"Try out your new skills against a variety of challenge problems, scattered throughout the book.";
            Console.WriteLine(pars.CountParagraphsInString());
            Console.ReadKey();
        }
    }
}
