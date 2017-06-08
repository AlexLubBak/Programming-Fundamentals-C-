using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string separate = Console.ReadLine();
            string evenOdd = Console.ReadLine();
            byte numberString = byte.Parse(Console.ReadLine());

            string sentanceOdd = "";
            string sentanceEven = "";

           


            for (int i = 0; i < numberString; i++)
            {
                string word = Console.ReadLine();

                if (i % 2 != 0 && evenOdd == "even")
                {


                    sentanceEven += word;
                    sentanceEven += separate;
                }
                else if (i % 2 == 0 && evenOdd == "odd")
                {
                    sentanceOdd += word;
                    sentanceOdd += separate;
                }
                
            }



  


            if (evenOdd=="even")
            {
                Console.WriteLine(sentanceEven.Remove(sentanceEven.Length-1, 1));
            }
            else
            {
                Console.WriteLine(sentanceOdd.Remove(sentanceOdd.Length - 1, 1));
            }
            
            
        }
    }
}
