using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_ADV03
{
    public delegate string BooksEngine(Book b);

    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> blist , BooksEngine books)
        {

            foreach (Book b in blist)
            {
                Console.WriteLine(books(b));
            }
        }
    }
}