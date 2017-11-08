using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Extension_Methods
{
    public static class StringExtensions
    {
        public static string ToRandomCase(this string text)
        {
            Random rand = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (rand.Next(2) == 1)
                {
                    sb.Append(text[i].ToString().ToUpper());
                }
                else
                {
                    sb.Append(text[i].ToString().ToLower());
                }
            }
            return sb.ToString();
        }
    }
}
