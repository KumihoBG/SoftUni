// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops;

using System;

namespace MatrixOfNumbers
    {
    class MatrixOfNumbers
        {
        static void Main()
            {
            Console.Write("Please, enter number \"n\" (n >= 1) (n <= 20): ");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
                {
                for (int column = row; column <= n + row - 1; column++)
                    {
                    Console.Write("{0} ", column);
                    }
                Console.WriteLine();
                }
            }
        }
    }
