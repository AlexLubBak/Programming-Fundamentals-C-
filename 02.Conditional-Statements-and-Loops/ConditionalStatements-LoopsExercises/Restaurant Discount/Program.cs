using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            if (countPeople<=50)
            {

                Console.WriteLine("We can offer you the Small Hall");
                if (package== "Normal")
                {
                    double totalPrice = 2500 + 500; ;
                    double totalPriceTemp = totalPrice - totalPrice * 0.05;
                    double pricePerPerson = totalPriceTemp / countPeople;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Gold")
                {
                    double totalPrice = 2500 + 750; ;
                    double totalPriceTemp = totalPrice - totalPrice * 0.10;
                    double pricePerPerson = totalPriceTemp / countPeople;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Platinum")
                {
                    double totalPrice = 2500 + 1000; ;
                    double totalPriceTemp = totalPrice - totalPrice * 0.15;
                    double pricePerPerson = totalPriceTemp / countPeople;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }

            }
            else if (countPeople > 50 && countPeople<=100)
            {

                Console.WriteLine("We can offer you the Terrace");
                if (package == "Normal")
                {
                    double totalPrice = 5000 + 500; ;
                    double totalPriceTemp = totalPrice - totalPrice * 0.05;
                    double pricePerPerson = totalPriceTemp / countPeople;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Gold")
                {
                    double totalPrice = 5000 + 750; ;
                    double totalPriceTemp = totalPrice - totalPrice * 0.10;
                    double pricePerPerson = totalPriceTemp / countPeople;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Platinum")
                {
                    double totalPrice = 5000 + 1000; ;
                    double totalPriceTemp = totalPrice - totalPrice * 0.15;
                    double pricePerPerson = totalPriceTemp / countPeople;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }

            }
            else if (countPeople > 100 && countPeople <= 120)
            {

                Console.WriteLine("We can offer you the Great Hall");
                if (package == "Normal")
                {
                    double totalPrice = 7500 + 500; ;
                    double totalPriceTemp = totalPrice - totalPrice * 0.05;
                    double pricePerPerson = totalPriceTemp / countPeople;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Gold")
                {
                    double totalPrice = 7500 + 750; ;
                    double totalPriceTemp = totalPrice - totalPrice * 0.10;
                    double pricePerPerson = totalPriceTemp / countPeople;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "Platinum")
                {
                    double totalPrice = 7500 + 1000; ;
                    double totalPriceTemp = totalPrice - totalPrice * 0.15;
                    double pricePerPerson = totalPriceTemp / countPeople;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }

            }
            else if (countPeople>120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

        }

        }
    }

