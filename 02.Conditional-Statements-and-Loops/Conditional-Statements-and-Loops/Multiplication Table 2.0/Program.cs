using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            if (numberTwo<=10)
            {
                for (int i = numberTwo; i <= 10; i++)
                {
                    int result = numberOne * i;
                    Console.WriteLine($"{numberOne} X {i} = {result}");

                }

            }
            else if (numberTwo>10)
            {
                int resultTemp = numberOne * numberTwo;
                Console.WriteLine($"{numberOne} X {numberTwo} = {resultTemp}");

            }


        }
    }
}
