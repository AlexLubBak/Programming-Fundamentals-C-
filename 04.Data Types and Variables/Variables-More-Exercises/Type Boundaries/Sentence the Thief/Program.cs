using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine();
            byte number = byte.Parse(Console.ReadLine());
            long thiefId = long.MinValue;
            var MinTypeValue = sbyte.MinValue;
            var MaxTypeValue = sbyte.MaxValue;

            while (number > 0)
            {
                var typeNumber = Console.ReadLine();

                if (type == "sbyte")
                {
                    try
                    {
                      
                        long currentID = sbyte.Parse(typeNumber);
                        thiefId = Math.Max(currentID, thiefId);
                    }

                    catch (Exception)
                    {

                    }
                }
                if (type == "int")
                {
                    try
                    {
                       
                        long currentID = int.Parse(typeNumber);
                        thiefId = Math.Max(currentID, thiefId);
                    }

                    catch (Exception)
                    {

                    }
                }
                if (type == "long")
                {

                    try
                    {
                       
                        long currentID = long.Parse(typeNumber);
                        thiefId = Math.Max(currentID, thiefId);
                    }

                    catch (Exception)
                    {

                    }
                }

                number--;

            }

            double years = 0.0;
            if (thiefId>0)
            {
                years = (long)(Math.Ceiling((decimal)thiefId / MaxTypeValue));
            }
            else
            {
                years =(long)(Math.Ceiling((decimal)thiefId / MinTypeValue));
            }

          
            
            if (years>1)
            {

                Console.WriteLine($"Prisoner with id {thiefId} is sentenced to {(years)} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {thiefId} is sentenced to {(years)} year");
            }
            



        }
    }
}
