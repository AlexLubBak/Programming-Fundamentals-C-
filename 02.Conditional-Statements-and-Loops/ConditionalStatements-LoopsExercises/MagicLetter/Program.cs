using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            int startLetter = char.Parse(Console.ReadLine().ToLower());
            int secondLetter = char.Parse(Console.ReadLine().ToLower());
            int ignoreLetter = char.Parse(Console.ReadLine().ToLower());


            int counter = 0;

            for (int i = startLetter; i <= secondLetter; i++)
            {

                for (int j = startLetter; j <= secondLetter; j++)
                {

                    for (int k = startLetter; k <= secondLetter; k++)
                    {

                        if (i != ignoreLetter && j != ignoreLetter && k != ignoreLetter)
                        {

                            Console.Write("{0}{1}{2} ", (char)(i), (char)(j), (char)(k));
                            counter++;
                        }

                    }

                }

            }
            




        }
    }
}
