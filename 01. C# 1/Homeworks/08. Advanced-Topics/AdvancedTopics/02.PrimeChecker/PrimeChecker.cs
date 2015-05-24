/*Write a Boolean method IsPrime(n) that check whether a given integer number n is prime.*/

namespace _02.PrimeChecker
    {
    using System;

    internal class PrimeChecker
        {
        private static void Main()
            {
            Console.Write("Enter some number to check if it is prime: ");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrimeN(n));
            }

        public static bool IsPrimeN(long num)
            {
            bool prime = true;
            for (int div = 2; div <= Math.Sqrt(num); div++)
                {
                if (num % div == 0 || num == 0 || num == 1)
                    {
                    prime = false;
                    break;
                    }
                }
            return prime;
            }
        }
    }
