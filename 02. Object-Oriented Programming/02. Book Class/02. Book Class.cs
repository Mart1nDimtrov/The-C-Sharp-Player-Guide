using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Book_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Harry Potter", "J. K. Rowling");

            book.SetTitle("Harry Potter and the Half-Blood Prince");
            Console.WriteLine(book.GetTitle());
        }
    }
}
