/*Write a program that reads from the console a number N and an array of integers given on a single line. Your task is to find all subsets within the array which have a sum equal to N and print them on the console (the order of printing is not important). Find only the unique subsets by filtering out repeating numbers first. In case there aren't any subsets with the desired sum, print "No matching subsets."*/

namespace _06.SubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SubsetSums
    {
        static void Main()
        {
            Console.Write("Enter number N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers on a single line, separated by space:");
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            num = num.Distinct().ToArray();
            double combinations = Math.Pow(2, num.Length);
            bool isFound = false;

            CalculateSums(combinations, num, n, isFound);
        }

        private static void CalculateSums(double combinations, int[] num, int n, bool isFound)
        {
            List<int> addInts = new List<int>();
            List<List<int>> sums = new List<List<int>>();

            for (int i = 1; i < combinations; i++)
            {
                int sum = 0;
                for (int z = 0; z < num.Length; z++)
                {
                    int mask = i & (1 << z);
                    if (mask != 0)
                    {
                        sum += num[num.Length - 1 - z];
                        addInts.Add(num[num.Length - 1 - z]);
                    }
                }

                if (sum == n)
                {
                    sums.Add(addInts);
                    isFound = true;
                }
                addInts = new List<int>();
            }
            if (!isFound)
            {
                Console.WriteLine("No matching subsets.");
            }
            else
            {
                List<List<int>> combinationsOfSums = new List<List<int>>(sums);

                for (int i = 0; i < combinationsOfSums.Count - 1; i++)
                {
                    int first = combinationsOfSums[i].First();
                    for (int j = i + 1; j < combinationsOfSums.Count; j++)
                    {
                        int second = combinationsOfSums[j].First();
                        if (combinationsOfSums[i].Count == combinationsOfSums[j].Count && first > second)
                        {
                            List<int> temp = combinationsOfSums[i];
                            combinationsOfSums[i] = combinationsOfSums[j];
                            combinationsOfSums[j] = temp;
                        }
                    }
                }
                foreach (var number in combinationsOfSums)
                {
                    Print(number, n);
                }
            }
        }

        static void Print(List<int> numbers, int sum)
        {
            foreach (var number in numbers)
            {
                Console.Write(number + " + ");
            }
            Console.WriteLine("\b\b\b = " + sum);
        }
    }
}
