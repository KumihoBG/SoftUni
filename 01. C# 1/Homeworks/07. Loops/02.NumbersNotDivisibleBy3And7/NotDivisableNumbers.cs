﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersNotDivisibleBy3And7
{
    internal class NotDivisableNumbers
    {
        private static void Main()
        {
            // Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space;
            Console.Write("Please, enter a positive integer: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i%3 != 0 && i%7 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

