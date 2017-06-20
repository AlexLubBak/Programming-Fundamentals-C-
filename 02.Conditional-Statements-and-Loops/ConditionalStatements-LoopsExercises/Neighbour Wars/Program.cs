using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoDamage = int.Parse(Console.ReadLine());
            int GoshoDamage = int.Parse(Console.ReadLine());

            int healthPesho = 100;
            int healthGosho = 100;

            int countRound = 0;


            do
            {
                healthGosho -= PeshoDamage;
                

                if (healthGosho > 0 && healthPesho > 0)
                {
                    countRound++;
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                }
                else if(healthGosho <= 0 )
                {
                    Console.WriteLine($"Pesho won in {countRound+1}th round.");
                    break;
                }

                
                if (countRound % 3 == 0)
                {
                    healthGosho += 10;
                    healthPesho += 10;
                }

                healthPesho -= GoshoDamage;
                

                if (healthPesho > 0 && healthGosho > 0)
                {
                    countRound++;
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                }
                else if ( healthPesho <= 0)
                {
                    Console.WriteLine($"Gosho won in {countRound+1}th round.");
                    break;
                }


                if (countRound % 3 == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }


            } while (healthGosho >0  && healthPesho > 0);


            
                             
        }


        }

    }





