using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Book_Library_Modification
{
    class Book
    {
        public Book(string title, string author, string publisher, DateTime releaseDate, string isbnNumber, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.IsbnNumber = isbnNumber;
            this.Price = price;
        }

        public string Title { set; get; }
        public string Author { set; get; }
        public string Publisher { set; get; }
        public DateTime ReleaseDate { set; get; }
        public string IsbnNumber { set; get; }
        public decimal Price { set; get; }

    }
}
