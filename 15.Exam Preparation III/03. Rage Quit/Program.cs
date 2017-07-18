using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();
            var matches = Regex.Matches(input, @"(\D+)(\d+)");
            StringBuilder result = new StringBuilder();
            int uniqueNum = 1;

            var str = string.Join("", matches.Cast<Match>().Select(m => m.Groups[1].Value).ToArray());

            uniqueNum = uniqueNum / str.Length;
            foreach (Match item in matches)
            {
                var symbol = new String(item.Groups[1].ToString().ToArray());
                var num = int.Parse(new String(item.Groups[2].ToString().ToArray()));
                for (int i = 0; i < num; i++)
                {
                    result.Append(symbol);
                }
            }
            uniqueNum = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueNum}");
            Console.WriteLine(result);

        }
    }
}
