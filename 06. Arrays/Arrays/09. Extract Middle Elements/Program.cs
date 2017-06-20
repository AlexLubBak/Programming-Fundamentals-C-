using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            

           int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lenght = array.Length;

            if (lenght==1)
            {
                Console.WriteLine("{ "+array[0]+" }");
                return;
            }
            if (lenght%2==0)
            {
                Console.WriteLine("{ "+ array[lenght/2-1]+", "+ array[lenght/2]+" }");

            }
            else
            {
                Console.WriteLine("{"+" "+ array[lenght/2-1]+", "+array[lenght/2] + ", " + array[lenght/2+1] +'}' );
            }

        }
    }
}
