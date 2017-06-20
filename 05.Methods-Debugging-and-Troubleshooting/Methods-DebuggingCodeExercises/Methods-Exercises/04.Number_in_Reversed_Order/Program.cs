using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Number_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 0.0;
            StringNumber(number);

        }


        public static void StringNumber(double number)

        {
            number = double.Parse(Console.ReadLine());
            string reverseNumber = new string(number.ToString().Reverse().ToArray());
            double reverseDoubleNumber = 0.0;

            if (double.TryParse(reverseNumber, out reverseDoubleNumber))
            {
                double reverseNumberEnd = reverseDoubleNumber;
                Console.WriteLine(reverseNumberEnd);
            }

        }
    }
}

