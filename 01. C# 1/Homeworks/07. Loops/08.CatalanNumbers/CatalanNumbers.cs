// Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100)

using System;
using System.Numerics;

namespace CatalanNumbers
    {
    class CatalanNumbers
        {
        static void Main()
            {
            Console.WriteLine("Enter an integer \"n\" >= 0:");
            int n = int.Parse(Console.ReadLine());
            int input = n;
            BigInteger a = 1;
            BigInteger b = 1;
            int n2 = 2 * n;

            while (n2 > 1)
                {
                a *= n2;
                n2--;
                }
            while (n > 1)
                {
                b *= n;
                n--;
                }
            BigInteger result = a / (b * b * (input + 1));
            Console.WriteLine("The Nth Catalan number for N = {0} is {1}.", input, result);
            }
        }
    }
