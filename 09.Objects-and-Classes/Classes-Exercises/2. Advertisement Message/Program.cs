using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };
            string[] events = { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself", " I am very satisfied.",
                "I feel great!" };
            string[] authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int indexPhrases = phrases.Length;
            int indexEvents = events.Length;
            int indexAuthors = authors.Length;
            int indexCities = cities.Length;

            int n = int.Parse(Console.ReadLine());
            Random phr = new Random();
            Random even = new Random();
            Random author = new Random();
            Random citi = new Random();
            int phrNumber = 0;
            int eventNumber = 0;
            int authorNumber = 0;
            int citiesNumber = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < indexPhrases; j++)
                {
                    phrNumber = phr.Next(indexPhrases);
                }
                for (int j = 0; j < indexEvents; j++)
                {
                    eventNumber = even.Next(indexEvents);
                }
                for (int j = 0; j < indexAuthors; j++)
                {
                    authorNumber = author.Next(indexAuthors);
                }
                for (int j = 0; j < indexCities; j++)
                {
                    citiesNumber = citi.Next(indexCities);
                }

                Console.WriteLine($"{phrases[phrNumber]} {events[eventNumber]} {authors[authorNumber]} – {cities[citiesNumber]}.");

            }
        }
    }
}
