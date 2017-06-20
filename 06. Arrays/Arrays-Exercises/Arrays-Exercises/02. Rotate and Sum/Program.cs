using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int length = array.Length;
            int[] arrayTemp = new int[length];
            int[] arraySumTemp = new int[length];
            int count = 0;
            

            for (int r = 1; r <= k; r++)
            {

                for (int i = 0; i <= length - 1; i++)
                {
                    
                    arrayTemp[(i + r) % length] = array[i];
                    count++;
                    if (count % length == 0)
                    {
                        for (int j = 0; j < length; j++)
                        {
                            arraySumTemp[j] += arrayTemp[j];
                        }
                        
                    }

                }

                

            }
            for (int i = 0; i < length; i++)
            {

                Console.Write(arraySumTemp[i] + " ");
            }
        }
    }
}
