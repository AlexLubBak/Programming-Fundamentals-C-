using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            uint days = (uint)(years * 365.2422);
            long hours = days * 24;
            ulong minutes = (ulong) (hours * 60);
            ulong seconds = (ulong)(minutes * 60);
            ulong miliSeconds = (ulong)(seconds * 1000);
            ulong microSeconds = (ulong)(miliSeconds * 1000);
            decimal nanoSeconds = (decimal)Math.Round(microSeconds * 1000M);
          
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliSeconds} milliseconds = {microSeconds} microseconds = {nanoSeconds} nanoseconds"   );


        }
    }
}
