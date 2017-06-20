using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Instruction_Set
{
    class Program
    {
        static void Main(string[] args)
        {

            string opCode = string.Empty;
            while (opCode != "END")
            {
                opCode = Console.ReadLine();
                string[] codeArgs = opCode.Split(' ');
                long result = 0;
                if (opCode == "END")
                {
                    continue;
                }

                if (codeArgs[0] == "INC")
                {
                    long operandOne = long.Parse(codeArgs[1]);
                    result = ++operandOne;
                }
                if (codeArgs[0] == "DEC")
                {
                    long operandOne = long.Parse(codeArgs[1]);
                    result = --operandOne;
                }
                if (codeArgs[0] == "ADD")
                {
                    long operandOne = long.Parse(codeArgs[1]);
                    long operandTwo = long.Parse(codeArgs[2]);
                    result = operandOne + operandTwo;
                }
                if (codeArgs[0] == "MLA")
                {
                    long operandOne = long.Parse(codeArgs[1]);
                    long operandTwo = long.Parse(codeArgs[2]);
                    result = operandOne * operandTwo;
                }

                Console.WriteLine(result);
            }

        }
    }
}
