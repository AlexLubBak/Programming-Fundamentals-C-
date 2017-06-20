using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int totallCalories = 0;

            for (int i = 1; i <=number; i++)
            {
                string ingredients = Console.ReadLine().ToLower();

                if (ingredients=="cheese")
                {
                    totallCalories += 500;
                }
                else if (ingredients == "tomato sauce")
                {
                    totallCalories += 150;
                }
                else if (ingredients == "salami")
                {
                    totallCalories += 600;
                }
                else if (ingredients == "pepper")
                {
                    totallCalories += 50;
                }

            }

            Console.WriteLine($"Total calories: {totallCalories}");
        }
    }
}
