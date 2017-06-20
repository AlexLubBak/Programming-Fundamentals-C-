﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            if (numArray.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                leftSum = numArray
                    .Take(i)
                    .Sum();
                rightSum = numArray
                    .Skip(i + 1)
                    .Sum();
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
