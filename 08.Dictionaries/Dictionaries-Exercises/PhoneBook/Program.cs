using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            var input = new List<string>();


            do
            {
                input = Console.ReadLine().Split(' ').ToList();


                if (input[0] == "A")
                {
                    phonebook[input[1]]= input[2];

                }
                else if (input[0] == "S")
                {

                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }

            } while (input[0] != "END") ;
            
            
        }
    }
}
