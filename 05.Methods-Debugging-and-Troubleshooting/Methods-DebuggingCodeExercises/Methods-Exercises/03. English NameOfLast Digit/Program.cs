using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_OfLast_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            
            string returnNumberWord = PrintEnglishNameNumber(str);
            Console.WriteLine(returnNumberWord); 

        }

        static string PrintEnglishNameNumber(string str)
        {
           long numberTemp = long.Parse(Console.ReadLine());

            long number= (long)Math.Abs(numberTemp % 10);


            if (number==0)
            {
                str = "zero";
            }
            if (number==1)
            {
                str = "one";
            }
            else if (number==2)
            {
                str = "two";
            }
            else if (number==3)
            {
                str = "three";
            }
            else if (number==4)
            {
                str = "four";
            }
            else if (number == 5)
            {
                str = "five";
            }
            else if (number == 6)
            {
                str = "six";
            }
            else if (number == 7)
            {
                str = "seven";
            }
            else if (number == 8)
            {
                str = "eight";
            }
            else if (number == 9)
            {
                str = "nine";
            }

            return str;
        }
    

    }
}


