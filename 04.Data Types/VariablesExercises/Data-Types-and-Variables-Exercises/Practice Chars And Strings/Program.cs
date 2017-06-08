using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Chars_And_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable1 = Console.ReadLine();
            char variable2 = char.Parse(Console.ReadLine());
            char variable3 = char.Parse(Console.ReadLine());
            char variable4 = char.Parse(Console.ReadLine());
            string variable5 = Console.ReadLine();

            Console.WriteLine($"{variable1}");
            Console.WriteLine($"{variable2}");
            Console.WriteLine($"{variable3}");
            Console.WriteLine($"{variable4}");
            Console.WriteLine($"{variable5}");

        }
    }
}
