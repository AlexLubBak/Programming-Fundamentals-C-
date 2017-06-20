using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            long result = (long)Fibonacci_Numbers();
            Console.WriteLine(result);
        }

        public static long Fibonacci_Numbers()
        {
           int n = int.Parse(Console.ReadLine());

            int f0 = 1;
            int f1 = 1;
            int fubunachi = 0;


            if (n < 2)
            {
                fubunachi = 1;
            }

            for (int i = 0; i <= n - 2; i++)
            {

                fubunachi = f0 + f1;

                f0 = f1;
                f1 = fubunachi;

            }
            return fubunachi;



        }
    }
}
