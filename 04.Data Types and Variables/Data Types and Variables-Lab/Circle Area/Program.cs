using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double areaCircle = Math.PI *( r * r);

            Console.WriteLine($"{areaCircle:F12}");



        }
    }
}
