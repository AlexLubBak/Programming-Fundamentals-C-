using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayInput = Console.ReadLine()
                 .Split(' ')
                 .Select(int.Parse)
                 .ToArray();
            int startIndex = 0;
            int lenght = 1;
            int maxStartindex = 0;
            int maxLenth = 1;
            for (int i = 1; i < arrayInput.Length; i++)
            {
                if (arrayInput[i] > arrayInput[i - 1])
                {
                    lenght++;
                    if (lenght > maxLenth)
                    {
                        maxLenth = lenght;
                        maxStartindex = startIndex;
                    }
                }
                else
                {
                    startIndex = i;
                    lenght = 1;
                }
            }

            for (int i = maxStartindex; i < maxStartindex + maxLenth; i++)
            {
                Console.Write(arrayInput[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
