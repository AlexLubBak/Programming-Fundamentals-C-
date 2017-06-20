using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            int numberMaxTemp = GetMax(numberOne, numberTwo);
            int numberMax = GetMax(numberMaxTemp, numberThree);
            Console.WriteLine($"{numberMax}");


        }

        static int GetMax(int numberOne, int numberTwo)
        {
          int numberMax = Math.Max(numberOne, numberTwo);
            return numberMax;
        }
    }
}
