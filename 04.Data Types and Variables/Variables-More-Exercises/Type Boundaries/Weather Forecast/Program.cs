using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = Console.ReadLine();

            try
            {
                sbyte.Parse(number);
                Console.WriteLine("Sunny");
            }
            catch (Exception)
            {

                try
                {
                    int.Parse(number);
                    Console.WriteLine("Cloudy");
                }
                catch (Exception)
                {

                    try
                    {
                        long.Parse(number);
                        Console.WriteLine("Windy");
                    }
                    catch (Exception)
                    {

                        try
                        {
                            decimal.Parse(number);
                            Console.WriteLine("Rainy");
                        }
                        catch (Exception)
                        {

                            return;
                        }
                    }
                }
            }
        }
    }
}
