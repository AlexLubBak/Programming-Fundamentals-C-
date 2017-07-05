using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read input Data

            string[] allSinger = Regex.Split(Console.ReadLine(), @"\s*,\s*"); // parvi nachin za splitvane


            string[] Allsong= Console.ReadLine() //vtori nachin za splitvane
                .Split(',')
                .Select(s => s.Trim())
                .ToArray();

            //Collect awards for each player
            var awardsByPlayer = new Dictionary<string, List<string>>();

            foreach (var p in allSinger)
            {
                awardsByPlayer[p] = new List<string>(); //za vseki pevec ima v nachaloto prazen spisak s nagradi
            }

            while (true)
            {
                var command = Console.ReadLine();
                if (command=="dawn")
                {
                    break;
                }

                var tokens = Regex.Split(command, @"\s*,\s*");
                var player = tokens[0];
                var song = tokens[1];
                var award = tokens[2];

                if (allSinger.Contains(player)&&Allsong.Contains(song))
                {
                    awardsByPlayer[player].Add(award);
                }


            }

            //Print the result

            var result = awardsByPlayer
                .Select(item => new
                {
                    playerName = item.Key,
                    awards = item.Value.Distinct().OrderBy(a=>a),
                    awardsCount = item.Value.Distinct().Count()

            })
            .OrderByDescending(p=>p.awardsCount)
            .ThenBy(p=>p.playerName)
            .Where(p=>p.awardsCount>0 )
            .ToArray();
                
                
            foreach (var p in result)
            {
                Console.WriteLine($"{p.playerName}: {p.awardsCount} awards");

                foreach (var aw in p.awards)
                {
                    Console.WriteLine($"--{aw}");
                }

            }
            if (result.Length==0)
            {
                Console.WriteLine("No awards");
            }


        }
    }
}
