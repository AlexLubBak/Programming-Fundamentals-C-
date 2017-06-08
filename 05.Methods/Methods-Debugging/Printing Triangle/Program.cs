using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int endNumber = int.Parse(Console.ReadLine());
            int startNumber = 1;

            for (int i = startNumber; i <= endNumber; i++)
            {
                PrintLine(startNumber, i);
            }

            for (int i = endNumber - 1; i >= 1; i--)
            {
                PrintLine(startNumber, i);
            }

        }

        static void PrintLine(int startNumber, int endNumber)
        {
            for (int i = startNumber; i <= endNumber; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();



        }
    }
}
