using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeatherAndFooterLine(n);
            for (int i = 1; i <= n - 2; i++)
            {
                PrintBody(n);

            }

            PrintHeatherAndFooterLine(n);


        }

        private static void PrintBody(int n)
        {
            Console.Write('-');

            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine('-');
        }

        static void PrintHeatherAndFooterLine(int n)
        {
            Console.Write(new string('-', 2 * n));
            Console.WriteLine();
        }

    }
}
