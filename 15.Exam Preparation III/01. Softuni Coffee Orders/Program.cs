
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal totalSum = 0;
            List<decimal> orders = new List<decimal>();
            for (int i = 0; i < n; i++)
            {
                var capsulePrice = decimal.Parse(Console.ReadLine());
                var dateOrder = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCout = int.Parse(Console.ReadLine());
                int daysPerMonth = System.DateTime.DaysInMonth(dateOrder.Year, dateOrder.Month);
                decimal currentSum = capsulePrice * capsulesCout * daysPerMonth;

                totalSum += currentSum;
                orders.Add(currentSum);
            }

            foreach (var item in orders)
            {
                Console.WriteLine($"The price for the coffee is: ${item:f2}");
            }
            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
