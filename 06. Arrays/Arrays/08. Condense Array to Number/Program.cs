using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int length = intList.Count;



            for (int i = length-1; i > 0; i--)
            {
                for (int j = 0; j < length-1; j++)
                {
                    if (j+1<length)
                    {
                        intList[j] = intList[j] + intList[j + 1];
                    }
                    else
                    {
                        intList.RemoveRange(length - 1, 1);
                    }
                                       
                }
               
            }

            Console.WriteLine(intList[0]);
        }

        }
    }

