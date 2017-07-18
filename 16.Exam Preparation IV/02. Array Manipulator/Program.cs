using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arry = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var line = Console.ReadLine();

            while (line != "end")
            {
                var input = line.Split(' ').ToArray();
                var command = input[0];
                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(input[1]);
                        arry = ExcchangeArray(arry, index);
                        break;
                    case "max":
                    case "min":
                        var type = input[1];
                        GetValueByType(arry, type, command);
                        break;
                    case "first":
                    case "last":
                        var count = int.Parse(input[1]);
                        var evenOrOdd = input[2];

                        FindFirstOrLastEvenOrOdd(arry, count, evenOrOdd, command);
                        break;

                    default:
                        break;
                }
                line = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", arry)}]");
        }

        private static void FindFirstOrLastEvenOrOdd(int[] arry, int count, string evenOrOdd, string command)
        {
            if (count > arry.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var parity = evenOrOdd == "even" ? 0 : 1;  //вземи "evenOrOdd" и виж дали е "even", ако е even искам да си нула иначе 1.
            var evenOrOddElement = arry.Where(a => a % 2 == parity).ToArray(); //филтрират се четните или нечетните в зависимост дали е подадено 0 или 1.

            var evenOrOddList = new List<int>();
            if (command == "first")
            {
                evenOrOddList.AddRange(evenOrOddElement.Take(count));
            }
            else
            {
                evenOrOddList.AddRange(evenOrOddElement.Skip(evenOrOddElement.Length - count));
            }

            Console.WriteLine($"[{string.Join(", ", evenOrOddList)}]");
        }

        private static void GetValueByType(int[] arry, string type, string command)
        {
            var parity = type == "even" ? 0 : 1;   //вземи "evenOrOdd" и виж дали е "even", ако е even искам да си нула иначе 1.
            var evenOrOddElement = arry.Where(a => a % 2 == parity).ToArray();  //филтрират се четните или нечетните в зависимост дали е подадено 0 или 1.
            if (!evenOrOddElement.Any())                //ако няма такива елементи принтираме, че ги няма
            {
                Console.WriteLine("No matches");
                return;
            }
            int minOrMAx;                       //търсим минималния и максималния елемент в масива от четни и нечетни номера.
            if (command == "min")
            {
                minOrMAx = evenOrOddElement.Min();                  //минималните четни и нечетни
            }
            else
            {
                minOrMAx = evenOrOddElement.Max();              //максималните четни и нечетни
            }
            var index = Array.LastIndexOf(arry, minOrMAx);          //взимаме индекса на последния намерен минимален или максимален.

            Console.WriteLine(index);                   //принтираме индекса му.
        }

        private static int[] ExcchangeArray(int[] arry, int index)
        {
            var isvalidIndex = index >= 0 && index < arry.Length;

            if (isvalidIndex)
            {
                var rightPart = arry.Take(index + 1).ToArray();
                var leftPart = arry.Skip(index + 1).ToArray();
                arry = leftPart.Concat(rightPart).ToArray();
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            return arry;

        }
    }
}
