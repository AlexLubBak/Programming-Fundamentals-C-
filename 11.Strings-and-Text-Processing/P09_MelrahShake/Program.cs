using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = Console.ReadLine();
            var pattern = Console.ReadLine();

            bool shakeIt = true;

            while (shakeIt)
            {
                var firstIndex = text.IndexOf(pattern);
                var lastIndex = text.LastIndexOf(pattern);
                if (firstIndex + pattern.Length - 1 < lastIndex &&
                    pattern != string.Empty)
                {
                    text = text.Remove(lastIndex, pattern.Length);
                    text = text.Remove(firstIndex, pattern.Length);
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    shakeIt = false;
                    Console.WriteLine("No shake.");
                    Console.WriteLine(text);
                }
            }

            }
        }
}
