using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeArrival = Console.ReadLine()
                .Split(':')
                .Select(int.Parse)
                .ToList();

            var steps = int.Parse(Console.ReadLine());
            var secondByStep = int.Parse(Console.ReadLine());
            long secondInSteps =  (long)steps * secondByStep;

            long hour = timeArrival[0] * 3600;
            long minute = timeArrival[1] * 60;
            long second = timeArrival[2];


            long allSecond = hour + minute + second + secondInSteps;

            if (allSecond>(24*60*60))
            {
                allSecond = allSecond - (24 * 60 * 60);
            }


            long endSeconds = allSecond % 60;
            long endMinutes = (allSecond / 60) % 60;
            long endHours = (allSecond / 60 / 60) % 24;


            if (endHours>23)
            {
                endHours = endHours - 24;
            }
            if (endMinutes>59)
            {
                endMinutes = endMinutes - 60;
                endHours++;
            }
            if (endSeconds>59)
            {
                endSeconds = endSeconds - 60;
                endMinutes++;
            }

            Console.WriteLine("Time Arrival: {0:d2}:{1:d2}:{2:d2}", endHours, endMinutes, endSeconds);
          
        }
    }
}
