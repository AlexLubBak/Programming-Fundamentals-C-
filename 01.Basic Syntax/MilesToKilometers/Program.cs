using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            float miles = float.Parse(Console.ReadLine());

            double kilometers = miles*1.60934;

            Console.WriteLine($"{kilometers:F2}");


        }
    }
}
