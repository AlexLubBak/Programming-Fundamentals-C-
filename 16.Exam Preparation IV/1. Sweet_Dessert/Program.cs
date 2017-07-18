using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var guests = decimal.Parse(Console.ReadLine());
            var bananaPriceOne = decimal.Parse(Console.ReadLine());
            var eggPriceOne = decimal.Parse(Console.ReadLine());
            var berryPriceKG = decimal.Parse(Console.ReadLine());

            var nededSetOfProducts = Math.Ceiling(guests / 6);

            //For a set of 6  (one set) she needs 2 bananas, 4 eggs and 0.2 kilos berries.
            decimal neededMoney = nededSetOfProducts * ((bananaPriceOne * 2m) + (eggPriceOne * 4m) + (berryPriceKG / 5m));

            if (neededMoney > money)
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney - money:f2}lv more.");
            }
            else if (neededMoney <= money)
                Console.WriteLine($"Ivancho has enough money - it would cost {neededMoney:f2}lv.");

        }
    }
}
