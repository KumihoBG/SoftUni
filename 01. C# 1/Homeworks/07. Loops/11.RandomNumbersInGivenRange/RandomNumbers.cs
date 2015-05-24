// Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max];
using System;

namespace RandomNumbersInGivenRange
    {
    class RandomNumbers
        {
        static void Main()
            {
            Random random = new Random(); // Random generator, must be outside the loop for correct results
            Console.Write("Please, enter a number \"n\": ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please, enter the minimum number: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Please, enter the maximum number: ");
            int max = int.Parse(Console.ReadLine());
            if (min < max && min != max)
                {
                for (int i = 1; i < n; i++)
                    {
                    n = random.Next(min, max);
                    Console.Write(n + " ");
                    }
                }
            else
                {
                Console.WriteLine("The maximum number should be greater than the minimum one.");
                }
            }
        }
    }

