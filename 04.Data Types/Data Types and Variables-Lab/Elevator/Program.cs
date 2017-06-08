using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            if (persons%capacity==0)
            {
                Console.WriteLine(persons/capacity);
            }
            else
            {
                int courses = persons / capacity;
                Console.WriteLine($"{courses+1}");
            }

        }
    }
}
