using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            bool newWordY = word.EndsWith("y");
            bool newWordS = word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z");
            bool newWordCH = word.EndsWith("ch") || word.EndsWith("sh");
            string newWord = "";

            if (newWordY)
            {
               newWord  = word.Remove(word.Length - 1, 1);
                Console.WriteLine($"{newWord}ies");

            }
            else if (newWordCH)
            {
               
                Console.WriteLine($"{word}es");
            }
            else if (newWordS)
            {
              
                Console.WriteLine($"{word}es");
            }
            else
            {
                Console.WriteLine($"{word}s");
            }

        }
    }
}
