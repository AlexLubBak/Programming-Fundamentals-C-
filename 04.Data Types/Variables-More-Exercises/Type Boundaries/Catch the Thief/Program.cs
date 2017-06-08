using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            byte number = byte.Parse(Console.ReadLine());
            long thiefId = long.MinValue;

            while (number>0)
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
            Console.WriteLine($"{thiefId}");
        }

                
    }

            

}

        
       
    

