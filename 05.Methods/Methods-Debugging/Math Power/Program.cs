using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());

            Console.WriteLine(NumberPower(number, pow));

        }

         static double NumberPower(double number, double pow)
        {

            return Math.Pow(number, pow);
        }
    }
}
