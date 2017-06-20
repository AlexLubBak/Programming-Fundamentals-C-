using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());

            double priceStudio = 0.0;
            double priceDouble = 0.0;
            double priceSuite = 0.0;



            if (mounth == "May" || mounth == "October")
            {

                if (nightCount <= 7)
                {
                     priceStudio = 50 * nightCount;
                     priceDouble = 65 * nightCount;
                    priceSuite = 75 * nightCount;

                }
                else if (nightCount > 7 && mounth == "May")
                {
                     priceStudio = 50 * nightCount - 50 * nightCount * 0.05;
                     priceDouble = 65 * nightCount;
                     priceSuite = 75 * nightCount;
                }
                else if (nightCount > 7 && mounth == "October")
                {
                     priceStudio = (50 * (nightCount - 1) - 50 * (nightCount-1) * 0.05);
                     priceDouble = 65 * nightCount;
                     priceSuite = 75 * nightCount;


                }

            }
            else if (mounth == "June" || mounth == "September")
            {

                if (nightCount <= 7 )
                {
                    priceStudio = 60 * nightCount;
                    priceDouble = 72 * nightCount;
                     priceSuite = 82 * nightCount;

                }
                else if (nightCount > 7 && nightCount<=14 && mounth == "September")
                {
                     priceStudio = 60 * (nightCount-1);
                     priceDouble = 72 * nightCount;
                     priceSuite = 82 * nightCount;
                }
                else if (nightCount > 7 && nightCount <= 14 && mounth == "June")
                {
                     priceStudio = 60 * nightCount;
                     priceDouble = 72 * nightCount;
                     priceSuite = 82 * nightCount;
                }
                else if (nightCount > 14 && mounth == "September")
                {
                     priceStudio = 60 * (nightCount - 1);
                     priceDouble = 72 * nightCount- 72 * nightCount*0.1;
                     priceSuite = 82 * nightCount;
                }
                else if (nightCount > 14 && mounth == "June")
                {
                     priceStudio = 60 * nightCount;
                     priceDouble = 72 * nightCount - 72 * nightCount * 0.1;
                     priceSuite = 82 * nightCount;
                }

            }
            else if (mounth == "July"|| mounth == "August" || mounth == "December")
            {
                if (nightCount<=14)
                {
                     priceStudio = 68 * nightCount;
                     priceDouble = 77 * nightCount;
                     priceSuite = 89 * nightCount;
                }
                else if (nightCount >14)
                {
                     priceStudio = 68 * nightCount;
                     priceDouble = 77 * nightCount;
                     priceSuite = 89 * nightCount - 89 * nightCount*0.15;
                }

            }


            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
            Console.WriteLine($"Double: {priceDouble:F2} lv.");
            Console.WriteLine($"Suite: {priceSuite:F2} lv.");


        }
    }
}
