using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordOne = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var wordTwo = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            int lengthWordOne = wordOne.Length;
            int lengthWordTwo = wordTwo.Length;
            int length = 0;
            int countOne = 0;
            int countTwo = 0;
            
                length = Math.Min(lengthWordTwo, lengthWordOne);
           
            for (int i = 0; i < length; i++)
            {
                if (wordOne[i]>wordTwo[i])
                {
                    countOne++;

                }
                else
                {
                    countTwo++;
                }
            }

            if (countOne > countTwo || lengthWordOne > lengthWordTwo)
            {
                for (int i = 0; i < lengthWordTwo; i++)
                {
                    Console.Write(wordTwo[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < lengthWordOne; i++)
                {
                    Console.Write(wordOne[i]);
                }
            }
            else if (countOne < countTwo || lengthWordOne < lengthWordTwo)
            {
                for (int i = 0; i < lengthWordOne; i++)
                {
                    Console.Write(wordOne[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < lengthWordTwo; i++)
                {
                    Console.Write(wordTwo[i]);
                }
            }

        }
    }
}
