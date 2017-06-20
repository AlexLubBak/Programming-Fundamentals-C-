using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ", Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .OrderByDescending(n => n)
                .Take(3)));

            


            
        }
    }
}
