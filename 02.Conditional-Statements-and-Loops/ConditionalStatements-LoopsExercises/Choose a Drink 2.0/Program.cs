using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double athletePay = quantity * 0.7;
            double businessmanPay = quantity * 1.0;
            double businesswomanPay = quantity * 1.0;
            double SoftUniStudentPay = quantity * 1.7;
            double otherPay = quantity * 1.2;
            

            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine($"The {profession} has to pay {athletePay:F2}.");
                    break;
                case "Businessman":
                    Console.WriteLine($"The {profession} has to pay {businessmanPay:F2}.");
                    break;
                case "Businesswoman":
                    Console.WriteLine($"The {profession} has to pay {businesswomanPay:F2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {profession} has to pay {SoftUniStudentPay:F2}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {otherPay:F2}.");
                    break;
            }


        }
    }
}
