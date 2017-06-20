using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 1; i <=10; i++)
            {
                int oddNumber = int.Parse(Console.ReadLine());

                if (oddNumber % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    int oddNumberTemp = Math.Abs(oddNumber);

                    Console.WriteLine($"The number is: {oddNumberTemp}");
                    return;

                }


            }

        }
    }
}
