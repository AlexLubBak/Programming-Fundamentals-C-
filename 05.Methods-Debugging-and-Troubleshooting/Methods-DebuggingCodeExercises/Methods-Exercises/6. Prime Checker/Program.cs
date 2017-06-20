using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(n));

        }

        public static bool IsPrime(long n)
        {


            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {

                if (n % i == 0)
                {
                    isPrime = false;
                    return isPrime;
                }


            }

            if (isPrime == true && n >= 2)
            {
                isPrime = true;
            }
            else
            {
                isPrime = false;
            }

            return isPrime;

        }


    }
}
