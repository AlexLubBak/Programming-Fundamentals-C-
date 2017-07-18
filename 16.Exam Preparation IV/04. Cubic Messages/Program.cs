using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {

            var pattern = @"^(\d+)([a-zA-Z]+)([^a-zA-Z]*)$";

            var textRegex = new Regex(pattern);
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Over!")
                {
                    break;
                }
                var match = textRegex.Match(line);

                if (!match.Success)
                {
                    continue;
                }
                var leftSide = match.Groups[1].Value;
                var message = match.Groups[2].Value;
                var rightSide = match.Groups[3].Value;

                var messageLenght = int.Parse(Console.ReadLine());
                if (message.Length != messageLenght)
                {
                    continue;
                }

                var verifyCode = new string((leftSide + rightSide).Where(char.IsDigit)
                    .Select(@char => int.Parse(@char.ToString()))
                    .Select(index => index >= 0 && index < message.Length ? message[index] : ' ')
                    .ToArray());

                Console.WriteLine($"{message} == {verifyCode}");
            }
        }
    }
}
