using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Count_Text
{
    public static class StringExtensions
    {
        public static int CountWordsInString(this string text)
        {
            return text
                .Split(new char[] {' ', '\n', '\t', '\r' })
                .Count();
        }
        public static int CountSentencesInString(this string text)
        {
            return text
                .Split(new char[] { '.' })
                .Where(s => s.Length != 0)
                .Count();    
        }
        public static int CountParagraphsInString(this string text)
        {
            return text
                .Split(new char[] { '\n' })
                .Where(s => s.Length != 0)
                .Count();
        }
    }
}
