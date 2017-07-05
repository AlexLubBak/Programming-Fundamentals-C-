using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._1.LibraryAndBook
{
    class Library
    {
        public Library(string name)
        {
            this.Name = name;
            this.Books = new List<Book>();
        }

        public string Name { set; get; }
        public List<Book> Books{set; get;}
    }
}
