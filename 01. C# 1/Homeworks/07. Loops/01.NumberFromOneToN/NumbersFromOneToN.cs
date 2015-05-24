using System;

namespace NumberFromOneToN
    {
    class NumbersFromOneToN
        {
        static void Main()
            {
            // Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space;
            Console.Write("Please, enter a positive integer: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                if (n > 0)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.WriteLine("This is not a valid number. Try again!");
                }      
            }
            }
        }
    }
