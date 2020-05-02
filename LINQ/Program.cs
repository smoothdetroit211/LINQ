using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();


            //LINQ Extension Methods
            var book = books.First(b => b.Title == "C# Advanced Topics");

            Console.WriteLine(book.Title + " " + book.Price);
            //Console.WriteLine(book == null);

        }
    }
}
