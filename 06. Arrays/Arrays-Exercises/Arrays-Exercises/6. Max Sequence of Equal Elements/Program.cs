using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var bestIndex = 0;
            var bestLength = 1;
            var currentIndex = 0;
            var currentLength = 1;

            for (int i = 1; i < array.Length; i++)
            {
            
                if (array[i]==array[i-1])
                {
                    currentLength++;

                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestIndex = currentIndex;
                    }

                }
                else
                {
                    currentIndex = i;
                    currentLength = 1;
                }
                
            }

            for (int i = bestIndex; i < bestIndex+bestLength; i++)
            {
                Console.Write(array[i]+" ");
            }

        }
    }
}
