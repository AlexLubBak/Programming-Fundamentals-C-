using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = byte.Parse(Console.ReadLine());
            int capacity = 0;
            int capacityTemp = 0;

            for (int i = 1; i <=number; i++)
            {
                int litres = int.Parse(Console.ReadLine());

                

               
                capacityTemp = capacity;

                if ((capacity += litres) > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    capacity = capacityTemp;
                }
              

            }

            Console.WriteLine($"{capacity}");


        }
    }
}
