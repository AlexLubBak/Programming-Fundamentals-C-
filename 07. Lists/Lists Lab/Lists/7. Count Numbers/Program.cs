using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            numbers.Sort();

            for (int i = 0; i < numbers.Count;)
            {
                var count = numbers.Count(x => x == numbers[i]);
                Console.WriteLine($"{numbers[i]} -> {count}");
                for (int j = 0; j < count; j++)
                {
                    numbers.Remove(numbers[i]);
                }
                
                count = 0;
                if (numbers.Count==0)
                {
                    return;
                }
            }
            

        }
    }
}
