using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {

            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int hourMinutes = hour * 60;
            int Allminutes = hourMinutes + minutes + 30;

            int hourEnd = Allminutes / 60;
            int minutesEnd = Allminutes % 60;

            if (hourEnd>0 && hourEnd<24 && minutesEnd<10)
            {
                Console.WriteLine($"{hourEnd}:0{minutesEnd}");
            }
            else if (hourEnd > 0 && hourEnd < 24 && minutesEnd >= 10 && minutesEnd<60)
            {
                Console.WriteLine($"{hourEnd}:{minutesEnd}");
            }
            else if (hourEnd > 23 && minutesEnd < 10)
            {
                
                hourEnd = 0;
                
                Console.WriteLine($"{hourEnd}:0{minutesEnd}");
            }
            else if (hourEnd > 23 && minutesEnd >= 10 && minutesEnd<60)
            {
                hourEnd = 0;
                Console.WriteLine($"{hourEnd}:{minutesEnd}");
            }
            

        }
    }
}
