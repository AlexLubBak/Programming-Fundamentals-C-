using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            int n5 = 0;

            if (b-a<5)
            {
                Console.WriteLine("No");
            }
            else
            {
             
                    for ( n1 =a; n1 <= b; n1++)
                    {
                        for ( n2 = a; n2 <= b; n2++)
                        {
                            for (  n3 = a; n3 <=b; n3++)
                            {
                                for (  n4 = a; n4 <=  b; n4++)
                                {
                                    for (  n5 = a; n5 <= b; n5++)
                                    {

                                    if (a<=n1 && n1<n2  && n2 <n3  && n3 <n4  && n4 <n5  && n5 <=b )
                                    {
                                        Console.Write($"{n1} {n2} {n3} {n4} {n5}");
                                        Console.WriteLine();
                                    }
                                    
                                    }

                                }

                            }

                        }

                    }
              
            }
           
        }
    }
}
