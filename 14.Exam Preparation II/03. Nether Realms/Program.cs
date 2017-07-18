using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries) // вземаме стрингове разделени от запетая или спейс.
                .Select(Demon.Parse)            //тук минава през долния метод като дам всяко име на демон минава през регекс, прави се на числа и се сумират.
                .OrderBy(a => a.Name)  //подреждаме по име и го вкарваме в масив.
                .ToArray();



            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");    //за всеки член на масива demons принтираме създадените 
            }                                                                                           //от метода име, здраве и щета.

        }

       

        class Demon                                 //създаваме клас Демон, който има Име, Здраве и Щета. В класа правим и Метод, който взима по 
        {                                               
           
            public string Name { get; set; }

            public decimal Health { get; set; }

            public decimal Damage { get; set; }


            public static Demon Parse(string demonStr)          //създаваме метод, който прави демони с име здраве и щета
            {
                var name = demonStr;
                var damageRegex = new Regex (@"-?\d+(?:\.\d+)?");        //трябва да вземем аски кода на всички тези знаци и да ги сумираме. 
                var healthRegex = new Regex(@"[^\d+\-*\/\.]");


                var damage = damageRegex.Matches(demonStr) //за целта прилагаме шаблона върху името и целта е да намерим съвпадения Matches 
                    .Cast<Match>()           // Matches - колекция от съвпадения (мачове) и след това с Cast<Match> ги превръщаме в множество от мачове, които вече могат да се манипулират с LINQ 
                    .Select(a=>decimal.Parse(a.Value))          // Парсваме към числа и сумираме и присвояваме към променлива damage и health
                    .ToArray()
                    .Sum();

                var health = healthRegex.Matches(demonStr)   // в  damage и health получихме сумите на аски кодовете на знаците в името.
                    .Cast<Match>()
                    .Select(a=> (int)char.Parse(a.Value) )
                    .ToArray()
                    .Sum();

                var multiplyCount = demonStr.Count(a => a == '*'); //брои умноженията /звездичките*/
                var divideCount = demonStr.Count(a => a == '/'); //брои деленията /наклонените черти "/"/

                damage *= (decimal)Math.Pow(2, multiplyCount);    //след като имаме броя на * и / според условието трябва да повдигнем 2 
                damage /= (decimal)Math.Pow(2, divideCount);        //на броя на намерени * и /.

                var demon = new Demon()             //създаваме нов демон с име, здраве и щетата
                {

                    Name = name,
                    Health = health,
                    Damage = damage

                };
                return demon;   //връщаме резултата на метода по горе, където ще принтираме.
              
            }

        }
    }
}
