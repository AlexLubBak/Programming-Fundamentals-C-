using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            var pattern1 = @"(\+(?<country>[0-9]{3})(\s)(?<city>[0-9]{1})(\s)(?<number1>[0-9]{3})(\s)(?<number2>[0-9]{4}))\b";
            var pattern2 = @"(\+(?<country>[0-9]{3})(\-)(?<city>[0-9]{1})(\-)(?<number1>[0-9]{3})(\-)(?<number2>[0-9]{4}))\b";

            var inputPhoneNumber = Console.ReadLine();

            var phoneMatches = Regex.Matches(inputPhoneNumber, pattern1);
            var phoneMatchesTwo = Regex.Matches(inputPhoneNumber, pattern2);

            var matcedPhones = phoneMatches.Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            var matchedPhonesTwo = phoneMatchesTwo
                .Cast<Match>()
                .Select(a => a.Value.Trim())
            .ToArray();

            Console.Write(string.Join(", ", matcedPhones));
            Console.Write(", ");
            Console.Write(string.Join(", ", matchedPhonesTwo));

        }
    }
}
