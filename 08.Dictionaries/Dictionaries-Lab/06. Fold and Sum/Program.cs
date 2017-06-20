using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
                
            int k = numbers.Length/4;

            var LeftK = numbers
                .Take(k)
                .Reverse()
                .ToArray();
            var rightK = numbers
                .Reverse()
                .Take(k)
                .ToArray();
            var firstRow = LeftK
                .Concat(rightK)
                .ToArray();

            var secondRow = numbers
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            Console.WriteLine(String.Join(" ", firstRow.Zip(secondRow, (x, y) => (x + y))
                .ToList()));
                




        }
    }
}
