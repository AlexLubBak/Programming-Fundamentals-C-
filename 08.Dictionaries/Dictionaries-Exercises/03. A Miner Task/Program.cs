using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            var input = "";
            var dictionary = new Dictionary<string, int>();
         
            int inputInt = 0;
            do
            {
                input = Console.ReadLine();
                if (input=="stop")
                {
                    continue;
                }
                
                inputInt = int.Parse(Console.ReadLine());
                count++;
                
                if (dictionary.ContainsKey(input))
                    {
                        dictionary[input] += inputInt;
                    }
                    else
                    {
                        dictionary[input] = inputInt;
                    }
                
                
                
            } while (input !="stop");

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
           

        }
    }
}
