/* Modify the program you wrote for the previous problem to print the results in the following way: each line should contain the operands (numbers that form the desired sum) in ascending order; the lines containing fewer operands should be printed before those with more operands; when two lines have the same number of operands, the one containing the smallest operand should be printed first. If two or more lines contain the same number of operands and have the same smallest operand, the order of printing is not important.*/

namespace _07.SortedSubsetSums
    {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortedSubsetSums
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
                List<List<int>> combinationsOfSums = new List<List<int>>(sums.OrderBy(x => x.Count));

                foreach (var sum in combinationsOfSums)
                    {
                    sum.Sort();
                    }

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
