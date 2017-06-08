using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float metres = float.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            checked
            {
                int allSeconds = minutes * 60 + hours * 3600 + seconds;
                float allHours = (float)(allSeconds / 3600.0f);

                float miles = (float)(metres / 1609);

                float VperSec = metres / allSeconds;
                float VperHour = (float)((metres / 1000) / allHours);
                float VperMiles = (float)(miles / allHours);

                Console.WriteLine($"{VperSec}");
                Console.WriteLine($"{VperHour}");
                Console.WriteLine($"{VperMiles}");
            }

           

        }
    }
}
