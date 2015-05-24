// Write a program that calculates n! / k! for given n and k (1 < k < n < 100)
// Use only one loop

using System;
using System.Numerics; // add System.Numerics to the References, otherwise when you have bigger number
                       // you will receive System.OverFlowException for the value
namespace CalculateNK
    {
    class CalculateNK
        {
        static void Main()
            {
            Console.Write("Please, enter the first integer number (n < 100): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Now, enter the second one (1 < k < n): ");
            int k = int.Parse(Console.ReadLine());
            BigInteger calculation = 1;
            while (n - k >= 1)
                {
                calculation *= n;
                n--;
                }
            Console.WriteLine("Result: " + calculation);
            }

        }
    }

