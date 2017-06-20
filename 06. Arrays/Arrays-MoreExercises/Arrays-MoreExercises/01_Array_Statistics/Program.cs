using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numArray = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();
            int min = numArray.Min();
            int max = numArray.Max();
            int sum = numArray.Sum();
            double average = numArray.Average();

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
