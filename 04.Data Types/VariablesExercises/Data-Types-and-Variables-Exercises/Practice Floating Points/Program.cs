using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Floating_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number1 = decimal.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            decimal number3 = decimal.Parse(Console.ReadLine());


           Console.WriteLine($"{number1:F18}");
            Console.WriteLine($"{number2:F8}");
            Console.WriteLine($"{number3:F28}");
        }
    }
}
