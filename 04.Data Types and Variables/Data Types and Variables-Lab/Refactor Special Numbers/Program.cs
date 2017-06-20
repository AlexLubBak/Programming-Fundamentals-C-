using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sumOfI = 0;
                int number = i;
                bool True = true;
                while (number > 0)
                {
                    sumOfI += number % 10;
                    number = number / 10;
                }
                True = (sumOfI == 5) || (sumOfI == 7) || (sumOfI == 11);
                Console.WriteLine($"{i} -> {True}");
            }
        }
    }
}
