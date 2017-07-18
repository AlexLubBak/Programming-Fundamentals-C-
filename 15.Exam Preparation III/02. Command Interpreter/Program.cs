using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("end"))
            {
                var elements = command.Split(' ').ToArray();

                if (elements[0] == "reverse" || elements[0] == "sort")
                {
                    int startIndex = int.Parse(elements[2]);
                    int endIndex = int.Parse(elements[4]);
                    if (startIndex >= input.Length || startIndex < 0 || startIndex + endIndex > input.Length || endIndex < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else if (elements[0] == "reverse")
                    {
                        Array.Reverse(input, startIndex, endIndex);
                    }
                    else if (elements[0] == "sort")
                    {
                        Array.Sort(input, startIndex, endIndex);
                    }
                }
                else if (elements[0] == "rollRight")
                {
                    RollRight(input, elements);
                }
                else if (elements[0] == "rollLeft")
                {
                    RollLeft(input, elements);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", input).TrimEnd());
        }
        private static void RollLeft(string[] input, string[] elements)
        {
            long numOfRotations = long.Parse(elements[1]) % input.Length;
            if (numOfRotations >= 0)
            {
                for (int currentElement = 0; currentElement < numOfRotations; currentElement++)
                {
                    var firstElement = input[0];
                    Array.Copy(input, 1, input, 0, input.Length - 1);
                    input[input.Length - 1] = firstElement;
                }
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        private static void RollRight(string[] input, string[] elements)
        {
            long numOfRotations = long.Parse(elements[1]) % input.Length;
            if (numOfRotations >= 0)
            {
                for (int currentElement = 0; currentElement < numOfRotations; currentElement++)
                {
                    var lastElement = input[input.Length - 1];
                    Array.Copy(input, 0, input, 1, input.Length - 1);
                    input[0] = lastElement;
                }
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }

        }
}
}
