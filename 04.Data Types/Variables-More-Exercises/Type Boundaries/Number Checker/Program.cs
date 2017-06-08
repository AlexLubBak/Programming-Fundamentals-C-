using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            try
            {
                long.Parse(number);
                Console.WriteLine("integer");
            }
            catch (Exception)
            {

                Console.WriteLine("floating-point"); ;
            }

        }
    }
}
