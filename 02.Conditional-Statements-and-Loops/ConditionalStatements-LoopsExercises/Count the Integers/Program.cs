using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            dynamic variable;

             for (int i = 1; i <= 100; i++)
            {

                try
                {
                    variable = int.Parse(Console.ReadLine());
                                   count++;
                }
                catch (Exception)
                {

                        Console.WriteLine(count);
                        break;
                }
                }

              

            }



        }
    }

