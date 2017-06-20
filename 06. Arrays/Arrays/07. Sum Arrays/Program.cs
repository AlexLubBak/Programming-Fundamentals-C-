using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int lenght1 = array1.Length;
            int lenght2 = array2.Length;


            int[] sumOfArrays = new int[Math.Max(lenght1, lenght2)];

            for (int i = 0; i < sumOfArrays.Length; i++)
            {
                sumOfArrays[i] = array1[i % lenght1] + array2[i % lenght2];
            }

            Console.WriteLine(string.Join(" ", sumOfArrays));
        }
    }
}
