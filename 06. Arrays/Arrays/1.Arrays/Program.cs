using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //int lenght = dayOfWeek.Length;


           
            int number = int.Parse(Console.ReadLine());

            if (number > 0 && number < 8)
            {
                Console.WriteLine(dayOfWeek[number - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");


            }                

                

            }

        }
    }

