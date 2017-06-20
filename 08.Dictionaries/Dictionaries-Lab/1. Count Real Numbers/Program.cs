using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
          var  numbers = Console.ReadLine()
                            .Split(' ')
                            .Select(double.Parse);

          var countNumber = new SortedDictionary<double, int>();

            foreach(var num in numbers)
            {
                if (!countNumber.ContainsKey(num))
                {
                    countNumber[num] = 0;
                }
                countNumber[num]++;
            }

            foreach (var item in countNumber)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            

                

        }
    }
}
