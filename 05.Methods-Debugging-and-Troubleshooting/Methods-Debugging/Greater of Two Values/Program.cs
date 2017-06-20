using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            if (type == "int")
            {
                int numberOne = int.Parse(Console.ReadLine());
                int numberTwo = int.Parse(Console.ReadLine());

                GetMaxInt(numberOne,  numberTwo);
                int maxInt = GetMaxInt(numberOne, numberTwo);
                Console.WriteLine(maxInt);

            }
            else if (type=="char")
            {
                char charOne = char.Parse(Console.ReadLine());
                char charTwo = char.Parse(Console.ReadLine());

                GetMaxChar(charOne, charTwo);
                char maxChar = GetMaxChar(charOne, charTwo);
                Console.WriteLine(maxChar);
            }
            else if (type=="string")
            {
                string stringOne = Console.ReadLine();
                string stringTwo = Console.ReadLine();

                GetMaxString(stringOne, stringTwo);
                string maxString = GetMaxString(stringOne, stringTwo);
                Console.WriteLine(maxString);
            }


        }

        static string GetMaxString(string stringOne, string stringTwo)
        {
            if (stringOne.CompareTo(stringTwo)>0)
            {
               return stringOne;
            }
            else
            {
                return stringTwo;
            }
            
        }

         static char GetMaxChar(char charOne, char charTwo)
        {
            if (charOne>charTwo)
            {
                return charOne;
            }
            else
            {
                return charTwo;
            }
        }

        static int GetMaxInt(int numberOne, int numberTwo)
        {
            if (numberOne>numberTwo)
            {
                return numberOne;
            }
            else
            {
                return numberTwo;
            }
        }
    }
}
