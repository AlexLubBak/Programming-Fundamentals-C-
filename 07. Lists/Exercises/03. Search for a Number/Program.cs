using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var commands = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            numList = numList
                .Take(commands[0])
                .Skip(commands[1])
                .ToList();
            Console.WriteLine(
                numList.Contains(commands[2]) ?
                "YES!" :
                "NO!"
                );
        }
    }
}
