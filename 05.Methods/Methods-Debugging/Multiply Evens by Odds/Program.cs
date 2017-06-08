using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int result = ResultoftheProductoftheSumofEvenAndOdd(n);
            Console.WriteLine(result);
        }

        static int ResultoftheProductoftheSumofEvenAndOdd(int n)
        {
            int even = 0;
            int odd = 0;
            while (n!=0)
            {
                
                int number = n % 10;
                if (number%2==0)
                {
                    even += number;
                }
                else
                {
                    odd += number;
                }

                n = n / 10;


            }

            int result = Math.Abs(even) * Math.Abs(odd);
            return result;

            

        }
    }
}
