using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Regex.Escape(Console.ReadLine());
            var line = Console.ReadLine();
            var teamScore = new Dictionary<string, decimal>();
            var teamGoals = new Dictionary<string, decimal>();
            string pattern = string.Format(@"^.*(?:{0})([a-zA-Z]*)(?:{0}).* .*(?:{0})([a-zA-Z]*)(?:{0}).*(\d+:\d+).*$", key);
            var regex = new Regex(pattern);

            while (line != "final")
            {
                var matches = regex.Match(line);

                teamScore = CalculateScore(matches, teamScore, teamGoals);

                line = Console.ReadLine();
            }
            Printresult(teamScore, teamGoals);

        }

        private static void Printresult(Dictionary<string, decimal> teamScore, Dictionary<string, decimal> teamGoals)
        {
            Console.WriteLine("League standings:");
            int num = 1;

            foreach (var item in teamScore.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{num}. {item.Key} {item.Value}");
                num++;
            }
            Console.WriteLine($"Top 3 scored goals:");
            foreach (var item in teamGoals.OrderByDescending(a => a.Value).ThenBy(a => a.Key).Take(3))
            {
                Console.WriteLine($"- {item.Key} -> {item.Value}");
            }
        }

        private static Dictionary<string, decimal> CalculateScore(Match matches, Dictionary<string, decimal> teamScore,
            Dictionary<string, decimal> teamGoals)
        {

            var team1 = new string(matches.Groups[1].Value.ToUpper().Reverse().ToArray());
            var team2 = new string(matches.Groups[2].Value.ToUpper().Reverse().ToArray());
            var score = matches.Groups[3].Value.Split(':').Select(int.Parse).ToArray();
            int scoreT1 = 0;
            int scoreT2 = 0;
            if (score[0] > score[1])
            {
                scoreT1 = 3;
            }
            else if (score[0] < score[1])
            {
                scoreT2 = 3;
            }
            else
            {
                scoreT1 = 1;
                scoreT2 = 1;
            }

            if (!teamScore.ContainsKey(team1))
            {
                teamScore[team1] = scoreT1;
                teamGoals[team1] = score[0];
            }
            else
            {
                teamScore[team1] += scoreT1;
                teamGoals[team1] += score[0];
            }

            if (!teamScore.ContainsKey(team2))
            {
                teamScore[team2] = scoreT2;
                teamGoals[team2] = score[1];
            }
            else
            {
                teamScore[team2] += scoreT2;
                teamGoals[team2] += score[1];
            }
            return teamScore;
        

        }
    }
}
