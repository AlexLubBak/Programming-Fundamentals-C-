using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ", Console.ReadLine()
                 .ToLower()
                 .Split(new[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?' },
                 StringSplitOptions.RemoveEmptyEntries)
                 .Distinct()
                 .Where(w => w.Length < 5)
                 .OrderBy(w => w)
                 .ToList()));
                      
        }
    }
}
