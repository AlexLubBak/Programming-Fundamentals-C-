using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventsRegex =
                new Regex(@"(?<id>\d+)\s+#(?<eventName>\w+)\s*(?<participants>(?:@[a-zA-Z0-9'-]+\s*)*)");
            var events = new Dictionary<int, Event >();
            
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Time for Code")
                {
                    break;
                }

                var @eventMatch = eventsRegex.Match(line);
                //тук ще проверяваме дали регекса е минал Success

                if (!@eventMatch.Success)
                {
                    continue;
                }

                var id = int.Parse(@eventMatch.Groups["id"].Value);  //взимаме от групите <id><eventsName> и <participants>.
                var eventName = @eventMatch.Groups["eventName"].Value;
                var participantsStr = @eventMatch.Groups["participants"].Value;

                var participants = new List<string>();
                //ако имаме участници ги записваме в List, а ако нямаме е празен List;

                if (participantsStr.Length>0)  //проверяваме дали дължината не е по голяма от нула и ако е сплитваме по спейс и трием празните позиции.
                {
                    participants.AddRange(participantsStr     //добави стринга, който е сплитнат и са махнати всички празни места в него.
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                }

                //Трябва да проверим дали има Ewent с такова име

                if (!events.ContainsKey(id))
                {
                    var @event = new Event    // ако няма го създаваме
                    {
                        Name = eventName,
                        Participants = participants
                    };
                    events[id] = @event;
                }

                //Трябва да направим следната проверка. 
                //Ако получим втори евент с едно и също id трябва проверим дали евента съществува и ако не съществува само тогава да му добавим участниците.

                if (events[id].Name==eventName) //ako e vyarno dobavyame uchastnicite
                {
                    events[id].Participants.AddRange(participants);

                }


            }

            foreach (var @event in events)
            {
                @event.Value.Participants = @event.Value
                    .Participants
                    .Distinct()
                    .OrderBy(a => a)
                    .ToList();// правим всичките ни участници уникални.
            }

            var sortedEvents = events
                .OrderByDescending(pair => pair.Value.Participants.Count)
                .ThenBy(a => a.Value.Name)
                .Select(a => a.Value)
                .ToArray();

            foreach (var @event in sortedEvents)
            {
                Console.WriteLine($"{@event.Name} - {@event.Participants.Count}");

                foreach (var participant in @event.Participants)
                {
                    Console.WriteLine(participant);
                }

            }
        }

        class Event
        {
            public string Name { set; get; }

            public List<string> Participants {set; get;} 
        }

    }

}
