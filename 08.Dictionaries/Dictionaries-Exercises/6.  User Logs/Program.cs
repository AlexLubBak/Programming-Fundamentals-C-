using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {

            var logFile = new SortedDictionary<string, Dictionary<string, int>>();
            string input = "";
            int count = 0;
            while (input!="end")
            {

                input = Console.ReadLine();
                if (input == "end")
                {
                    return;
                }
                var tokens = input.Split(' ');

                var ipTemp = tokens[0].Split('=');
                var usernameTemp = tokens[2].Split('=');
                var ip = ipTemp[1];
                var username = usernameTemp[1];


                if (!logFile.ContainsKey(username))
                {
                    logFile[username] = new Dictionary<string, int>();
                    
                }
                if (!logFile[username].ContainsKey(ip))
                {
                    
                    logFile[username][ip] = 0;
                    count = 1;

                }

                logFile[username][ip] +=count ;

                foreach (var item in logFile)
                {
                    username = item.Key;
                    Console.WriteLine($"{username}: ");

                    int number = 0;
                    foreach (var ipi in item.Value)
                    {
                        var ips = ipi.Key;
                        var numberLineIp = (item.Value).Count;
                       
                        if (numberLineIp-1==number)
                        {
                            Console.WriteLine($"{string.Join(" ", ips)} => {string.Join(" ", ipi.Value)}. ");
                        }
                        else
                        {
                            Console.Write($"{string.Join(" ", ips)} => {string.Join(" ", ipi.Value)}, ");
                        }
                        number++;
                      
                    }
                }
                

            }


        }
    }
}
