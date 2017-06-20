using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
               
            }
            var sumNumber = 0;
            var minNumber = 0;
            var maxNumber = 0;
            var averageNumber = 0.0;
            
                sumNumber = number.Sum();
                minNumber = number.Min();
                maxNumber = number.Max();
                averageNumber = number.Average();

            Console.WriteLine($"Sum = {sumNumber}");
            Console.WriteLine($"Min = {minNumber}");
            Console.WriteLine($"Max = {maxNumber}");
            Console.WriteLine($"Average = {averageNumber}");
        }
    }
}
