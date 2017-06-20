using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                var tokens = line.Split(' ');
                var name = tokens[1];
                var ip = tokens[0];
                var duration = int.Parse(tokens[2]);

                if (!dictionary.ContainsKey(name))
                {
                    dictionary[name] = new SortedDictionary<string, int>();
                }

                if (!dictionary[name].ContainsKey(ip))
                {
                    dictionary[name][ip] = 0;
                }
                dictionary[name][ip] += duration;
            }

            foreach (var item in dictionary)
            {
                var name = item.Key;
                var ipAndDuration = item.Value;

                var sumTotalDuration = ipAndDuration.Sum(a=>a.Value);
                var ips = ipAndDuration.Select(a => a.Key).ToArray();

                Console.WriteLine($"{name}: {sumTotalDuration} [{string.Join(", ", ips)}]");
            }

        }
    }
}
