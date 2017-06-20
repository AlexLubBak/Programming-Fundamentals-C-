using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine()
                .ToLower()
                .Split(' ');

            var result = new Dictionary<string, int>();
            foreach (var item in word)
            {
                if (!result.ContainsKey(item))
                {
                    result[item] = 0;
                }
                result[item]++;
            }
            var listOdd = new List<string>();

            foreach (var item in result)
            {
                if (item.Value %2!=0)
                {
                    listOdd.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", listOdd));





        }
    }
}
