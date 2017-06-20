using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            int priceMaterialsFirst = int.Parse(Console.ReadLine());
            int priceMaterialsSecond = int.Parse(Console.ReadLine());

            long priceMaterialSbyte = 0;
            long priceMaterialInt = 0;


            if (priceMaterialsFirst>priceMaterialsSecond)
            {
                priceMaterialInt = priceMaterialsFirst;
               priceMaterialSbyte = priceMaterialsSecond;
            }
            else
            {
                priceMaterialSbyte = priceMaterialsFirst;
                priceMaterialInt = priceMaterialsSecond;
            }

            long allPrice =((long)(4 * priceMaterialSbyte) + (long)(10 * priceMaterialInt));

            Console.WriteLine($"{allPrice}");

        }
    }
}
