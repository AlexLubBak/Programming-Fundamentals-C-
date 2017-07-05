using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allTicket = Regex.Split(Console.ReadLine(), @"\s*,\s*")
                .Select(t=>t.Trim())
               .Where(t => t.Length > 0)
               .ToArray();

            int numberTicket = allTicket.Length;

            foreach( var t in allTicket)
            {
                if (t.Length!=20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var leftSide =  t.Substring(0, 10);

                    var rightSide = t.Substring(10, 10);
                    var maxLeftLongest = FindMaxEqualSeq(leftSide);
                    var maxRightLongest = FindMaxEqualSeq(rightSide);

                    int leftSideLongest = maxLeftLongest.Length;
                    int rightSideLongest = maxRightLongest.Length;

                    if (maxRightLongest[0] == maxLeftLongest[0] &&
                        leftSideLongest>=6 && rightSideLongest>=6 &&
                        "@#$^".Contains(maxLeftLongest[0]))
                    {
                       

                        int minLength = Math.Min(leftSideLongest, rightSideLongest);

                        if (minLength == 10)
                        {
                            Console.WriteLine($"ticket \"{t}\" - {minLength}{maxLeftLongest[0]} Jackpot!");
                        }
                        else
                        {
                           
                                Console.WriteLine($"ticket \"{t}\" - {minLength}{maxLeftLongest[0]}");
                           
                               
                            
                        }


                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{t}\" - no match");
                    }

                }
                
            }

                      
        }

        static string FindMaxEqualSeq(string s)
        {
            var bestStr ="" + s[0];
            var max = 1;

            for (int i = 0; i < s.Length-1; i++)
            {
                var ch = s[i];
                var count = 1;

                while (i+count < s.Length && s[i+count]== s[i])
                {
                    count++;

                    if (count>max)
                    {
                        max = count;
                        bestStr = s.Substring(i, count);

                    }

                }

            }
            return bestStr;

        }
    }
}
