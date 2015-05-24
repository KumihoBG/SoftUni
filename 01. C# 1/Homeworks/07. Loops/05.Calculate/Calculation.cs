// Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n;
// Use only one loop. Print the result with 5 digits after the decimal point;
using System;
using System.Numerics; // add System.Numerics to the References, otherwise when you have bigger number
                        // you will receive System.OverFlowException for the value
namespace CalculateNAndX
    {
    class Calculation
        {
        static void Main()
            {
            Console.Write("Please, enter the first integer number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Now, enter the second one: ");
            int x = int.Parse(Console.ReadLine());
            double sum = 1;
            BigInteger unknown = 1;
            int some;

            for (int i = 1; i <= n; i++)
                {
                some = i;
                while (some > 1)
                    {
                    unknown *= some;
                    some--;
                    }
                sum += (double)unknown / Math.Pow(x, i);
                unknown = 1;
                }
            Console.WriteLine("Sum = {0:F5}", sum);
            }
        }
    }
