using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            int aTemp = a;
            int bTemp = b;

            Console.WriteLine("After:");
            Console.WriteLine($"a = {bTemp}");
            Console.WriteLine($"b = {aTemp}");


        }
    }
}
