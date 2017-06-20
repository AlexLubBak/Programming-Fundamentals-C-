using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var numberOne = int.Parse(Console.ReadLine());
            var numberTwo = int.Parse(Console.ReadLine());
            var sum = numberOne + numberTwo;

            Console.WriteLine($"{numberOne} + {numberTwo} = {sum}");
        }
    }
}
