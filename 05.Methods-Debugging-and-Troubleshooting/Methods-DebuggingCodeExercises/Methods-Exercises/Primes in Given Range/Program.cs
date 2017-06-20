using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {

            int startNum = int.Parse(Console.ReadLine());
           int  endNum = int.Parse(Console.ReadLine());

            List<int> primes = GetPrimes(startNum, endNum);


            foreach (var item in primes)
            {
                int lastNumber = primes.Last();

                if (item != lastNumber)
                {
                    Console.Write(item + ", ");
                }
                else
                {
                    Console.Write(item);
                }
                
            }

            if (primes.Capacity==0)
            {
                Console.WriteLine("(empty list)");
            }
            
            

                

        }

        static List<int> GetPrimes(int startNum, int endNum)
        {
            

            List<int> primesList = new List<int>();


            for (int i = startNum; i <= endNum; i++)
            {

                bool prime = true;
                double numSqrt = Math.Sqrt(i);

                for (int div = 2; div <= numSqrt; div++)

                {
                    if (i % div == 0)
                    {
                        prime = false;
                       
                        break;
                    }
                }


                if (prime == true && i >= 2)
                {
                    prime = true;
                    primesList.Add(i);
                }
                else
                {
                    prime = false;
                }
                

            }

            return primesList;

        }



    }
}
