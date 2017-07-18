using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfColums = int.Parse(Console.ReadLine());

            var ladyBugIndexes = (Console.ReadLine())
                .Split()
                .Select(int.Parse)
                .Where(t => t >= 0 && t < numberOfColums)
                .ToArray();

            var ladyBugs = new int[numberOfColums];

        

            foreach (var item in ladyBugIndexes)
            {
                ladyBugs[item] = 1;
            }

            while (true)
            {
                var inputCommand = Console.ReadLine();


                if (inputCommand == "end")
                {
                    break;
                }

                var token = inputCommand.Split();
                var inputCommandIndex = int.Parse(token[0]);
                var inputCommandDirection = token[1];
                var inputCommandSteps = int.Parse(token[2]);


                var isInsideIndex = inputCommandIndex >= 0 && inputCommandIndex < numberOfColums;


                if (!isInsideIndex)
                {
                    continue;

                }

                var ladyBugsExist = ladyBugs[inputCommandIndex] == 1;

                if (!ladyBugsExist)
                {
                    continue;
                }

                MoveLadybug(ladyBugs, inputCommandIndex, inputCommandDirection, inputCommandSteps);
                
            }

            Console.WriteLine(string.Join(" ", ladyBugs));
        }
    



         static void MoveLadybug(int[] ladyBugs, int inputCommandIndex, string inputCommandDirection, int inputCommandSteps)
        {
            if (inputCommandDirection == "left")
            {
                inputCommandSteps = -inputCommandSteps;

            }
            var nextIndex = inputCommandIndex + inputCommandSteps;

            ladyBugs[inputCommandIndex] = 0;

            var untilFindPlace = false;

            while (!untilFindPlace)
            {
                if (nextIndex <0|| nextIndex > ladyBugs.Length-1)
                {
                    untilFindPlace = true;
                    break;
                }

                var ladyBugsAlreadyExistOnIndex = ladyBugs[nextIndex] == 1;

                if (ladyBugsAlreadyExistOnIndex)
                {
                    nextIndex +=inputCommandSteps;
                    continue;
                }

                ladyBugs[nextIndex] = 1;
                untilFindPlace = true;


            }
        }
    }
}
