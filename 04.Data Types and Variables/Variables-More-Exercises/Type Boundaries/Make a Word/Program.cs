using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {


            byte n = byte.Parse(Console.ReadLine());

            
            char[] array = new char[n];
            
           for (int i = 0; i <n; i++)
           {
            
             char letter = char.Parse(Console.ReadLine());
            
              array[i] = letter;
            
            }
            Console.Write("The word is: ");
            for (int i = 0; i <n; i++)
            {
              Console.Write(array[i]);
            }
            
            }

        }
    }

