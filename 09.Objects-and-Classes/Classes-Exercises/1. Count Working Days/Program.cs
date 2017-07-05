using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {

            var startDay = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDay = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var workingDay = 0;

            while (startDay<=endDay)
            {
                if (IsWorkingDay(startDay))
                {
                    workingDay++;
                }

                startDay = startDay.AddDays(1);
            }

            Console.WriteLine(workingDay);



           
            }
        static bool IsWorkingDay(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;

            }

            return !IsOfficialHoliday(date);
        }


        private static bool IsOfficialHoliday(DateTime date)
        {
            string dateString = $"{date.Day}-{date.Month}";
            string[] holidays = {"1-1", "3-3", "1-5",
                "6-5", "24-5", "6-9", "22-9", "1-11",
                "24-12", "25-12", "26-12"};

            return holidays.Contains(dateString);
        }
    }
}
