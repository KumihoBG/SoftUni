/*Write a method that calculates all prime numbers in given range and returns them as list of integers:*/

namespace _03.PrimesInGivenRange
    {
    using System;
    using System.Collections.Generic;

    internal class PrimesInGivenRange
        {
        private static void Main()
            {
            Console.Write("Enter the start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter the end number: ");
            int end = int.Parse(Console.ReadLine());

            List<int> testPrimes = FindPrimesInRange(start, end);
            Console.WriteLine(string.Join(", ", testPrimes));
            }

        private static List<int> FindPrimesInRange(int startNum, int endNum)
            {
            List<int> primesList = new List<int>();
            bool[] storage = new bool[10000000];

            for (int i = 2; i < storage.Length; i++)
                {
                storage[i] = true;
                }

            for (int i = 2; i < Math.Sqrt(storage.Length); i++)
                {
                if (storage[i])
                    {
                    for (int j = i * i; j < storage.Length; j = j + i)
                        {
                        storage[j] = false;
                        }
                    }
                }

            for (int i = startNum; i <= endNum; i++)
                {
                if (storage[i])
                    {
                    primesList.Add(i);
                    }
                }
            return primesList;
            }
        }
    }
