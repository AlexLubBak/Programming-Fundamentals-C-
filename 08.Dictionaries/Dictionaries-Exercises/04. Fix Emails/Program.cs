using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "";
            var NameAndEmail = new Dictionary<string, string>();
            do
            {
                name = Console.ReadLine();
                if (name=="stop")
                {
                    continue;
                }
               
                var email = Console.ReadLine();
                var ukEmail = email.Substring(email.Length - 2).ToLower();
                if (!ukEmail.Equals("uk")&&!ukEmail.Equals("us"))
                {
                    NameAndEmail[name] = email;
                }
                

            } while (name !="stop");
            
           
            foreach (var item in NameAndEmail)
            {
                
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                   
                
               
            }
        }
    }
}
