using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string unit = Console.ReadLine();
            double valueUnit = double.Parse(Console.ReadLine());

            switch (unit)
            {
                case "miles":
                    double kilometres = valueUnit * 1.6; 
                    Console.WriteLine($"{valueUnit} miles = {kilometres:F2} kilometers");
                    break;
                case "inches":
                    double centimeters = valueUnit * 2.54;
                    Console.WriteLine($"{valueUnit} inches = {centimeters:F2} centimeters");
                    break;
                case "feet":
                    centimeters = valueUnit * 30;
                    Console.WriteLine($"{valueUnit} feet = {centimeters:F2} centimeters");
                    break;
                case "yards":
                    double meters = valueUnit * 0.91;
                    Console.WriteLine($"{valueUnit} yards = {meters:F2} meters");
                    break;
                case "gallons":
                    double liters = valueUnit * 3.8;
                    Console.WriteLine($"{valueUnit} gallons = {liters:F2} liters");
                    break;


                default:
                    break;
            }

        }
    }
}
