using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+(\s{1})[A-Z][a-z]+\b";

            string names = Console.ReadLine();

            MatchCollection matchedNamed = Regex.Matches(names, pattern);

            foreach (Match name in matchedNamed)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
