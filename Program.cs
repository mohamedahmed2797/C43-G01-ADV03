using static C43_G01_ADV03.Program;
using static System.Reflection.Metadata.BlobBuilder;

namespace C43_G01_ADV03
{
    internal class Program
    {
        public delegate string bookFunction(Book b);

        static void Main(string[] args)
        {
            #region BOOK
            #region a. User Defined Delegate Datatype (BOOK)

            //Book book = new Book(" 100", "Programming", new string[] { "Ahmed", "Mohamed" }, new DateTime(2010, 7, 7), 500);
            //BookInfo bookInfo = DisplayBookInfo; ;
            //bookInfo(book);
            //Console.WriteLine("------------------------------");

            #endregion
            #region b. BCL Delegates (Action)
            //Action<Book> book02 = DisplayBookInfo;
            //DisplayBookInfo(book);
            //Console.WriteLine("------------------------------");

            #endregion
            #region  b. BCL Delegates (Func)
            //Func<Book, string> GetIsbn = GETISBN;
            //string ISBN = GetIsbn(book);
            //Console.WriteLine($"Book ISBN ={ISBN}");
            //Console.WriteLine("------------------------------");

            #endregion
            #region b. BCL Delegates (predicate)
            //    Predicate<Book> isExpensive = IsExpensive;
            //bool expensive = isExpensive(book);
            //Console.WriteLine($"Is the book expensive? {expensive}");
            //    Console.WriteLine("------------------------------");

            #endregion
            #region c. Anonymous Method (GetISBN)
            //Func<Book, string> GetIsbn01 = delegate (Book b)

            //{
            //    return b.ISBN; 
            //}; string ISBN01 = GetIsbn(book);
            //Console.WriteLine($"Book ISBN = {ISBN}");
            //Console.WriteLine("------------------------------");
            #endregion
            #region d. Lambda Expression (GetPublicationDate)
            //Func<Book, DateTime> GetPublicationDate = (b) => b.PublicationDate;

            //DateTime publicationDate = GetPublicationDate(book);
            //Console.WriteLine($"Book Publication Date = {publicationDate}");
            //Console.WriteLine("------------------------------");
            #endregion
            #endregion
            #region BookFunctions
            #region a. User Defined Delegate Datatype(BookFunctions)
            Book book05 = new Book("101", "c#", new string[] { "mohamed ahmed", "ahmed kamal" }, new DateTime(2007, 7, 7), 600);
            bookFunction getTitle = BookFunctions.GetTitle;
            Console.WriteLine($"the book title is {getTitle(book05)} ");

            bookFunction getAuther = BookFunctions.GetAuthor;
            Console.WriteLine($"the book authers are {getAuther(book05)} ");
            bookFunction getPrice = (Book b) => BookFunctions.GetPrice(b).ToString();
            Console.WriteLine($"book price {getPrice(book05)}");
            Console.WriteLine("-------------------------------");
            #endregion
            #region b. BCL Delegates (BookFunctions)
            Action<Book> bookInfo = (b) => Console.WriteLine(b.ToString());
            bookInfo(book05);
            Console.WriteLine("------------------------------");
            Func<Book, string> getISBN = (b) => b.ISBN;
            Console.WriteLine($"Book ISBN: {getISBN(book05)}");
            Console.WriteLine("------------------------------");

            Predicate<Book> isExpensive = (b) => b.Price > 400;
            bool expensive = isExpensive(book05);
            Console.WriteLine($"Is the book expensive? {expensive}");
            Console.WriteLine("------------------------------");


            #endregion
            #region c. Anonymous Method (GetISBN) (BookFunctions)
            Book book06 = new Book("102", "php", new string[] { "mohamed ahmed", "ahmed kamal" }, new DateTime(2007, 7, 7) ,700);
            bookFunction getISBN01 = delegate (Book b)
            {
                return b.ISBN;
            };
            string isbn = getISBN(book06);
            Console.WriteLine($"Book ISBN = {isbn}");
            Console.WriteLine("------------------------------");


            #endregion
            #region d. Lambda Expression (GetPublicationDate) (BookFunctions)
            Book book07 = new Book("103", "Java Script", new string[] { "mohamed ahmed", "ahmed kamal" }, new DateTime(2007, 7, 7), 700);
            Func<Book, DateTime> getPublicationDate = (book) => book.PublicationDate;
            DateTime publicationDate = getPublicationDate(book06);
            Console.WriteLine($"Book Publication Date: {publicationDate}");
            Console.WriteLine("------------------------------");

            #endregion
            #endregion
            #region library Engine
            List<Book> bookList = new List<Book>
      
            {
                new Book("100", "C# Programming", new string[] { "Author A", "Author B" }, new DateTime(2010, 5, 1), 500),
                new Book("101", "Java Programming", new string[] { "Author C" }, new DateTime(2012, 7, 21), 600),
                new Book("102", "Python Programming", new string[] { "Author D", "Author E" }, new DateTime(2015, 8, 11), 700)
            };
            BooksEngine bookInfo01 = (Book b) => b.ToString();
            LibraryEngine.ProcessBooks(bookList, bookInfo01);
            Console.WriteLine("------------------------------");

            Action<Book> displayBookInfo = (book) => Console.WriteLine(book.ToString());
            foreach (Book book in bookList)
            {
                displayBookInfo(book);
            }
            Console.WriteLine("------------------------------");
            Func<Book, string> getTitle01 = (book) => book.Title;
            foreach (Book book in bookList)
            {
                Console.WriteLine($"Book Title: {getTitle(book)}");
            }
            Console.WriteLine("------------------------------");
            Predicate<Book> isExpensive01 = (book) => book.Price > 600;
            foreach (Book book in bookList)
            {
                Console.WriteLine($"Is the book expensive? {isExpensive01(book)}");
            }
            Console.WriteLine("------------------------------");

            Func<Book, string> getISBN02 = delegate (Book b)
            {
                return b.ISBN;
            };
            foreach (Book book in bookList)
            {
                string isbn02 = getISBN02(book);
                Console.WriteLine($"Book ISBN: {isbn02}");
            }
            Console.WriteLine("------------------------------");

            Func<Book, DateTime> getPublicationDate01 = (book) => book.PublicationDate;
            foreach (Book book in bookList)
            {
                DateTime publicationDate01 = getPublicationDate01(book);
                Console.WriteLine($"Book Publication Date: {publicationDate01.ToShortDateString()}");
            }

            #endregion
        }
        #region a. User Defined Delegate Datatype (BOOK)
        //public static void DisplayBookInfo(Book book)
        //{
        //    Console.WriteLine(book.ToString());
        //}
        //public static string GETISBN(Book book03)
        //{
        //    return book03.ISBN;
        //}
        //static bool IsExpensive(Book book)
        //{
        //    return book.Price > 400;
        //}
        #endregion
    }
}
