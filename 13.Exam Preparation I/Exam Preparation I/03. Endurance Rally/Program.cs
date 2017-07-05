using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allDrivers = Regex.Split(Console.ReadLine(), @"\s+")
                .Where(t => t.Length > 0)
                .ToArray();
            double[] allPointsRoute = Regex.Split(Console.ReadLine(), @"\s+")
                .Where(t=>t.Length>0)
                .Select(p => double.Parse(p)*-1).ToArray();
            List<long> fuelFillingPoints = Regex.Split(Console.ReadLine(), @"\s")
                 .Where(t => t.Length > 0)
                 .Select(long.Parse)
                 .Distinct()
                .ToList();

            long lengthName = allDrivers.Length;
            long lengthPointRoute = allPointsRoute.Length;
            long lengthFillingPoints = fuelFillingPoints.Count;

            List<double> startingFuelDriver = new List<double>();
            long lengthList = startingFuelDriver.Count;

            var index = 0;
            for (int i = 0; i < lengthName; i++)
            {
                string driversName = allDrivers[i];

                for (int j = 0; j < 1; j++)
                {
                    double startingFuel = driversName[j];
                    startingFuelDriver.Add(startingFuel);
                }
                
            }

            foreach (var item in fuelFillingPoints)
            {
                if (item >= 0 && item < allPointsRoute.Length)
                {
                    allPointsRoute[item] *= -1.0;
                }
               

            }
                
        double startingFuelDriverTemp = 0.0;

            for (int i = 0; i < startingFuelDriver.Count; i++)
            {
                
                index = 0;
                for (int j = 0; j < lengthPointRoute; j++)
                {
                    
                    
                        startingFuelDriver[i] += allPointsRoute[j];

                        if (startingFuelDriver[i]<=0)
                        {
                           

                            Console.WriteLine($"{allDrivers[i]} - reached {index}");
                        break;
                        }
                    index++;

                    startingFuelDriverTemp = startingFuelDriver[i];
                }
                if (startingFuelDriver[i]>0)
                {
                    Console.WriteLine($"{allDrivers[i]} - fuel left {startingFuelDriver[i]:F}");
                }
             

            }
            
                       
        }
    }
}
