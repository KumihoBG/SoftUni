// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order;

using System;

namespace RandomizeTheNumbers
    {
    class RandomizeTheNumbers
        {
        static void Main()
            {
            Console.Write("Please, enter an integer number: ");
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 1; i < n; i++)
            {
                int rnd = random.Next(1, n + 1);
                Console.Write(rnd + " ");
            }
            }
        }
    }
