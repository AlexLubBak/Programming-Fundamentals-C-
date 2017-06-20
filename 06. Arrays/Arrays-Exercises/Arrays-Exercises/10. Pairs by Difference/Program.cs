using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfInts = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            double difference = double.Parse(Console.ReadLine());
            var counter = 0;
            for (int i = 0; i < arrayOfInts.Length - 1; i++)
            {
                for (int j = i + 1; j < arrayOfInts.Length; j++)
                {
                    if (Math.Abs(arrayOfInts[i] - arrayOfInts[j]) == difference)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
