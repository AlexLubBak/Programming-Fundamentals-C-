using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _6.Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            Library library = new Library("NewLibrary");

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] lineArg = line.Split(' ').ToArray();

                string title = lineArg[0];
                string author = lineArg[1];
                string publisher = lineArg[2];
                DateTime releaseDate = DateTime.ParseExact(lineArg[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbnNumber = lineArg[4];
                decimal price = decimal.Parse(lineArg[5]);
                Book book = new Book(title, author, publisher, releaseDate, isbnNumber, price);
                library.Books.Add(book);
            }
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Dictionary<string, DateTime> createTitleBook = CreateTitleBook(library);

            foreach (var item in createTitleBook.OrderBy(x=>x.Value).ThenBy(y=>y.Key))
            {
                string title = item.Key;
                DateTime releaseDate = item.Value.Date;

                if (releaseDate>startDate)
                {
                    Console.WriteLine($"{title} -> {releaseDate:dd.MM.yyyy}");
                }
            }

        }

        private static Dictionary<string, DateTime> CreateTitleBook(Library library)
        {
            Dictionary<string, DateTime> createTitleBook = new Dictionary<string, DateTime>();

            foreach (var book in library.Books)
            {
                string title = book.Title;

                if (!createTitleBook.ContainsKey(title))
                {
                    createTitleBook.Add(title, new DateTime());
                }

                createTitleBook[title] = book.ReleaseDate;

            }
            return createTitleBook;
        }
    }
}
