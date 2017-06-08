using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Boundaries
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "sbyte":
                    Console.WriteLine("127");
                    Console.WriteLine("-128");
                    break;
                case "byte":
                    Console.WriteLine("255");
                    Console.WriteLine("0");
                    break;
                case "short":
                    Console.WriteLine("32767");
                    Console.WriteLine("-32768");
                    break;
                case "ushort":
                    Console.WriteLine("65535");
                    Console.WriteLine("0");
                    break;
                case "int":
                    Console.WriteLine("2147483647");
                    Console.WriteLine("-2147483648");
                    break;
                case "uint":
                    Console.WriteLine("4294967295");
                    Console.WriteLine("0");
                    break;
                case "long":
                    Console.WriteLine("9223372036854775807");
                    Console.WriteLine("-9223372036854775808");
                    break;
                case "ulong":
                    Console.WriteLine("18446744073709551615");
                    Console.WriteLine("0");
                    break;

                default:
                    break;
            }


        }
    }
}
