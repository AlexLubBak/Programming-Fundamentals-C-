using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2._1.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();



            string pattern = @"\+359([ -])2\1\d{3}\1\d{4}\b";
   

            var phoneMatches = Regex.Matches(text, pattern);

            var result = phoneMatches.Cast<Match>()
                .Select(n=> n.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", result));


        }
    }
}
