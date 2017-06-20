using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            decimal sum = 0;

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    sum += nums[i] + nums[i - 1];
                    nums.RemoveRange(i - 1, 2);
                    nums.Insert(i - 1, sum);
                    i = 0;
                    sum = 0;
                }
            }
                Console.WriteLine(String.Join(" ", nums));

        }
    }
}
