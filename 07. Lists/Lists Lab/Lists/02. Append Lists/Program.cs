using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var listInteger = Console.ReadLine()
                .Split('|')
                .ToList();
            listInteger.Reverse();

            var result = new List<string>();
            List<int> listIntegerTemp = new List<int>();

            foreach (var item in listInteger)
            {
                List<string> nums = item.Split(' ').ToList();
                foreach (var num in nums)
                {
                    if (num!="")
                    {
                        result.Add(num);
                    }

                }

            }
            

            Console.WriteLine(String.Join(" ", result));



        }
    }
}
