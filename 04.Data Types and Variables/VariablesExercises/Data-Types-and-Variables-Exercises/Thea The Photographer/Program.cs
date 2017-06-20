using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long days = 0;
            long second = 0;
            long hour = 0;
            long minuteInMinute = 0;

            long numberPictures = long.Parse(Console.ReadLine());
            int timeForFilter = int.Parse(Console.ReadLine());
            byte percentUsfulPictures = byte.Parse(Console.ReadLine());
            long timeUploadFiltredPictures = long.Parse(Console.ReadLine());


            int countUsfulPictures = (int) Math.Ceiling((numberPictures * percentUsfulPictures) / 100.00);
            long AllTimeForFilter = numberPictures * timeForFilter;
            

            long allTimeUploadPictures = timeUploadFiltredPictures * countUsfulPictures;

            long totalTimeSec = AllTimeForFilter + allTimeUploadPictures;


            second = totalTimeSec % 60;
            totalTimeSec = (totalTimeSec - second)/60;

            minuteInMinute = totalTimeSec % 60;
            totalTimeSec = (totalTimeSec - minuteInMinute)/60;

            hour = totalTimeSec % 24;
            totalTimeSec = (totalTimeSec - hour)/24;

            days = totalTimeSec;

                Console.WriteLine($"{days}:{hour:d2}:{minuteInMinute:d2}:{second:d2}");
            


        }
    }
}
