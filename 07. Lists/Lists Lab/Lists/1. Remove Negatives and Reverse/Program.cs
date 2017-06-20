using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var listInteger = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var listIntegerTemp = new List<int>();

            for (int i = 0; i < listInteger.Count; i++)
            {
                if (listInteger[i] > 0)
                {
                    listIntegerTemp.Add(listInteger[i]);

                }
            }
            listIntegerTemp.Reverse();

            if (listIntegerTemp.Count > 0)
            {
                Console.WriteLine(String.Join(" ", listIntegerTemp));
            }
            else
            {
                Console.WriteLine("empty");
            }



        }
    }
}
