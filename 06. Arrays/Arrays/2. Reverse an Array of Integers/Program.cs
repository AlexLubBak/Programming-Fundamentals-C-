using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Reverse_an_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] arrayOfInt = new int[number];

            for (int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());

                arrayOfInt[i] = n;
            }

            for (int i = number-1 ; i >=0 ; i--)
            {
                Console.Write($"{arrayOfInt[i]} ");
            }

        }
    }
}
