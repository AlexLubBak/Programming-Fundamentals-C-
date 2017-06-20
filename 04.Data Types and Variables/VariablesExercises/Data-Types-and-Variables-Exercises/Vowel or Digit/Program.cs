using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbol = Console.ReadLine();
           

            try
            {
                int.Parse(symbol);
                Console.WriteLine("digit");

            }
            catch (Exception)
            {
                char symbolTemp = char.Parse(symbol);
                if (symbolTemp=='a'||symbolTemp=='o'||symbolTemp=='e'||symbolTemp=='i'||symbolTemp=='u')
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }

        }
    }
}
