using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());


            for (int i = 1; i <= (height-1)/2; i++)
            {

                Console.WriteLine(new string(' ', (i-1))+new string('x', 1)+ new string(' ', height-(2*i))+ new string('x', 1));

            }

            Console.WriteLine(new string(' ', (height-1)/2)+new string('x', 1)+ new string(' ', (height-1)/2));

            for (int i = (height - 1)/2; i >=1 ; i--)
            {

                Console.WriteLine(new string(' ', (i - 1)) + new string('x', 1) + new string(' ', height - (2 * i)) + new string('x', 1));

            }

        }
    }
}
