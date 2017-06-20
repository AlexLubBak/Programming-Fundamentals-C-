using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int length = number.Length;
            int k = number.Length / 4;
            int[] numberLeft = new int[k];
            int[] numberRight = new int[k];
            int[] numberMidlle = new int[2 * k];

            int[] resultArray = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                numberLeft[i] = number[i];
                numberRight[i] = number[3 * k + i];
            }
            
            for (int i = 0; i < 2*k; i++)
            {
                numberMidlle[i] = number[k+i];
            }
            Array.Reverse(numberLeft);
            Array.Reverse(numberRight);
          
            for (int i = 0; i < k; i++)
            {
                resultArray[i] += numberLeft[i];
                resultArray[k + i] += numberRight[i];
            }
            
            for (int i = 0; i < 2*k; i++)
            {
                resultArray[i] = numberMidlle[i] + resultArray[i];
            }

            Console.WriteLine(string.Join(" ", resultArray));

        }
    }
}
