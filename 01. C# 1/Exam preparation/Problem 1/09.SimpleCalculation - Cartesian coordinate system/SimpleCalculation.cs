﻿using System;
using System.Numerics;

namespace _09.SimpleCalculation
    {
    class SimpleCalculation
        {
        static void Main()
            {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());

            if ((x == 0) && (y == 0))
                {
                Console.WriteLine("0");
                }
            else if ((x > 0) && (y > 0))
                {
                Console.WriteLine("1");
                }
            else if ((x < 0) && (y > 0))
                {
                Console.WriteLine("2");
                }
            else if ((x < 0) && (y < 0)) { Console.WriteLine("3"); }
            else if ((x > 0) && (y < 0))
                {
                Console.WriteLine("4");
                }
            else if (x == 0)
                {
                Console.WriteLine("5");
                }
            else if (y == 0)
                {
                Console.WriteLine("6");
                }
            else
                {
                Console.WriteLine("Please enter a number between -2 000 000 000 001 337 and 2 000 000 000 001 337");
                }
            }
        }
    }
