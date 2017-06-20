using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberBeer = int.Parse(Console.ReadLine());

            double Volume = 0.0;
            double volumeTemp = 0.0;
            string typeBeerTemp = "";

            for (int i = 1; i <=numberBeer; i++)
            {

                string typeBeer = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

               Volume = Math.PI * radius * radius * height;

                if (Volume>volumeTemp)
                {
                    volumeTemp = Volume;
                    typeBeerTemp = typeBeer;
                }
               

            }

            Console.WriteLine(typeBeerTemp);

            


        }
    }
}
