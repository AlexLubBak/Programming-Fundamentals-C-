using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayWordOne = Console.ReadLine().Split(' ').ToArray();
            string[] arrayWordTwo = Console.ReadLine().Split(' ').ToArray();
            
            int lengthOne = arrayWordOne.Length;
            int lengthTwo = arrayWordTwo.Length;
            int lengthMax = 0;
            int lengthMin = 0;
            if (lengthOne == lengthTwo)
            {
                lengthMax = lengthOne;
                lengthMin = lengthOne;
            }
            else
            {
                lengthMin = Math.Min(lengthOne, lengthTwo);
                lengthMax = Math.Max(lengthOne, lengthTwo);
            }

            int countEqualOne = 0;

            for (int i = 0; i < lengthMin; i++)
            {
                if (arrayWordOne[i] == arrayWordTwo[i])
                {
                    countEqualOne++;
                }
            }

            int countEqualTwo = 0;
            for (int i = lengthMin - 1; i >= 0; i--)
            {
                if (lengthOne > lengthTwo)
                {
                    if (arrayWordOne[i + (lengthOne - lengthTwo)] == arrayWordTwo[i])
                    {
                        countEqualTwo++;
                    }
                }
                else if(lengthOne < lengthTwo)
                {
                    if (arrayWordOne[i] == arrayWordTwo[i + (lengthTwo - lengthOne)])
                    {
                        countEqualTwo++;
                    }
                }
                else if (lengthOne == lengthTwo)
                {
                    if (arrayWordOne[i] == arrayWordTwo[i])
                    {
                        countEqualTwo++;
                    }
                }

            }

            if (countEqualOne == 0 && countEqualTwo == 0)
            {
                Console.WriteLine(countEqualOne);
            }
            else if (countEqualOne > countEqualTwo)
            {
                Console.WriteLine(countEqualOne);
            }
            else
            {
                Console.WriteLine(countEqualTwo);
            }



        }

    }
}

