using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());


            Console.WriteLine($"Name: {name}");
            Console.Write("Health: ");
            Console.Write(new string('|', 1) + new string('|', currentHealth) + new string('.', maxHealth-currentHealth)+ new string('|', 1));

            Console.WriteLine();

            Console.Write("Energy: ");
            Console.Write(new string('|', 1) + new string('|', currentEnergy) + new string('.', maxEnergy - currentEnergy) + new string('|', 1));

        }
    }
}
