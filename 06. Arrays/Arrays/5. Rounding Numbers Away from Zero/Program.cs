using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] roundedNumbers = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                roundedNumbers[i] = (int)Math.Round(array[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} => {roundedNumbers[i]}");
            }
        }
    }
}
