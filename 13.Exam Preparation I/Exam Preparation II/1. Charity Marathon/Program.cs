using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {

            ushort lengthMarathonInDay = ushort.Parse(Console.ReadLine());
            int numberRunners = int.Parse(Console.ReadLine());
            sbyte averageNumberLaps = sbyte.Parse(Console.ReadLine());
            int lapLength = int.Parse(Console.ReadLine());
            ushort trackCapacity = ushort.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

          

            long allMeters = 0;
            decimal allKilometers = 0;
            long capacityOfAllDay = lengthMarathonInDay * trackCapacity;
            decimal allMoney = 0;

            if (numberRunners>=capacityOfAllDay)
            {
                allMeters = capacityOfAllDay * lapLength * averageNumberLaps;
                allKilometers = (decimal)(allMeters / 1000.0);

                allMoney = moneyPerKilometer * allKilometers;

                Console.WriteLine($"Money raised: {allMoney:f2}");
            }
            else
            {
                allMeters = numberRunners * lapLength * averageNumberLaps;
                allKilometers = allMeters / 1000;

                allMoney = moneyPerKilometer * allKilometers;

                Console.WriteLine($"Money raised: {allMoney:f2}");
            }


        }
    }
}
