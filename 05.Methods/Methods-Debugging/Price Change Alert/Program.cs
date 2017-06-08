using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Change_Alert
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPrices = int.Parse(Console.ReadLine());
            double thresholdOfSignificance = double.Parse(Console.ReadLine())*100.0;
            double currentPrices = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberPrices - 1; i++)
            {
                double currentPriceTemp = double.Parse(Console.ReadLine());
                double DivTwoPrices = CalculatesTheDifference(currentPrices, currentPriceTemp);
                bool isSignificantDifference = IsDiff(DivTwoPrices, thresholdOfSignificance);

                string message = GetMassageOutput(
                    currentPriceTemp, currentPrices, DivTwoPrices, isSignificantDifference);
                Console.WriteLine(message);

                currentPrices = currentPriceTemp;
            }
        }

        private static string GetMassageOutput(
            double currentPriceTemp, double currentPrices, double DivTwoPrices, bool isSignificantDifference)

        {
            string massageOutput = "";
            if (DivTwoPrices == 0)
            {
                massageOutput = string.Format("NO CHANGE: {0}", currentPriceTemp);
            }
            else if (DivTwoPrices>0 && isSignificantDifference!=true)
            {
                massageOutput = string.Format(
                    "MINOR CHANGE: {0} to {1} ({2:F2}%)", currentPrices, currentPriceTemp, DivTwoPrices);
            }
            else if (isSignificantDifference && (DivTwoPrices > 0))
            {
                massageOutput = string.Format(
                    "PRICE UP: {0} to {1} ({2:F2}%)", currentPrices, currentPriceTemp, DivTwoPrices);
            }
            else if (isSignificantDifference && (DivTwoPrices < 0))
                massageOutput = string.Format(
                    "PRICE DOWN: {0} to {1} ({2:F2}%)", currentPrices, currentPriceTemp, DivTwoPrices);
            return massageOutput;
        }

        private static bool IsDiff(double thresholdOfSignificance, double DivTwoPrices)
        {
            if (Math.Abs(thresholdOfSignificance) >= DivTwoPrices)
            {
                return true;
            }
            return false;
        }

        private static double CalculatesTheDifference(double currentPrice, double currentPriceTemp)
        {
            double DivTwoPrices = (currentPriceTemp - currentPrice) *100.0/ currentPrice;
            return DivTwoPrices;
        }
    }
}
