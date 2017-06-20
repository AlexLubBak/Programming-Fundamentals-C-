using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

           
            

            for (int i = 1; i <=n; i++)
            {

                int sumOfDigits = 0;
                int digits = i;

                while (digits>0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;

                }


                bool True = (sumOfDigits == 5) || (sumOfDigits== 7) || (sumOfDigits == 11) == true;

                if (True)
                {
                    Console.WriteLine($"{i} => {True}");
                }
                else
                {
                    Console.WriteLine($"{i} => {false}");
                }


            }

        }
    }
}
