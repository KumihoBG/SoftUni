// Calculate N! / (K! * (N-K)!) - write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
using System;
using System.Numerics;

namespace CalculateFactorielDivisionNK
    {
    class FactorielExpression
        {
        static void Main()
            {
            Console.WriteLine("Enter an integer N > 1:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter an integer K (1 < k < n < 100):");
            int k = int.Parse(Console.ReadLine());
            int difference = n - k;

            BigInteger result1 = 1; 
            BigInteger result2 = 1;
            // N! / (K! * (N-K)!)
            while (n - k >= 1)  
                {
                result1 *= n;
                n--;
                }
            while (difference > 1) 
                {
                result2 *= difference;
                difference--;
                }
            Console.WriteLine("Result: " + result1 / result2);
            }
        }
    }
