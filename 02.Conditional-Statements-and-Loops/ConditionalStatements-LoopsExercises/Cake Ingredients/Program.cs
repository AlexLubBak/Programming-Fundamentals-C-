using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {

            int count=0;

            for (int i = 1;  ; i++)
            {
                string ingredient = Console.ReadLine();

                if (ingredient.Length>50)
                {
                    return;
                }

                if (ingredient=="Bake!")
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                    return;
                }
                Console.WriteLine($"Adding ingredient {ingredient}.");
                count++;
            }

        }
    }
}
