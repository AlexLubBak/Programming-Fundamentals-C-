using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());


            double energyContentGeneral = energyContent * volume / 100.0;
            double sugarContentGeneral = sugarContent * volume / 100.0;

            Console.WriteLine($"{volume}ml {product}:");
            Console.WriteLine($"{energyContentGeneral}kcal, {sugarContentGeneral}g sugars");

        }
    }
}
