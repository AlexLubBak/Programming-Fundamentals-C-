using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._1.LibraryAndBook
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            
            Library library = new Library("New Library");

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                string[] lineArg = line.Split(' ').ToArray(); //вземаме от входа ред по ред книгите и разделяме ги по спейс и ги вкарваме в масив.

                string title = lineArg[0]; //извличаме от масива заглавие автор и т.н.
                string author = lineArg[1];
                string publisher = lineArg[2];
                DateTime releaseDate = DateTime.ParseExact(lineArg[3], "d.M.yyyy", CultureInfo.InvariantCulture);
                string number = lineArg[4];
                decimal price = decimal.Parse(lineArg[5]);
                Book book = new Book(title, author, publisher, releaseDate, number, price); //създаваме нова книга с пропъртите от клас Book.
                library.Books.Add(book); //добавяме книга към библиотеката.

            }

            Dictionary<string, List<Book>> booksByAuthors =  CreateBooksByAuthors(library);

            foreach (var item in booksByAuthors.OrderByDescending(a=>a.Value.Select(x=>x.Price).Sum()).ThenBy(a=>a.Key))
            {
                string author = item.Key; 
                decimal priceTotal = item.Value.Select(x => x.Price).Sum();
                Console.WriteLine($"{author} -> {priceTotal:F2}");
            }

        }

        private static Dictionary<string, List<Book>> CreateBooksByAuthors(Library library) //метод, който пълни всички книги в речника
        {
            Dictionary<string, List<Book>> booksByAuthors = new Dictionary<string, List<Book>>(); //създаване на речник с Ключ Автор и стойност Лист от книги. Така ще имаме за всеки автор списък с книги.

            foreach (var book in library.Books)
            {
                string author = book.Author;
                if (!booksByAuthors.ContainsKey(author)) //проверка за съществуване на автора
                {

                    booksByAuthors.Add(author, new List<Book>());  //Ако автора не съществува го създаваме в Key na Dict. и 
                    //създаваме за Value  List от книги
                }

                booksByAuthors[author].Add(book);  //На същия автор ако съществува му добавяме новата книга.

                //foreach  го правим на метод 
            }
            return booksByAuthors;
        }
    }
}
