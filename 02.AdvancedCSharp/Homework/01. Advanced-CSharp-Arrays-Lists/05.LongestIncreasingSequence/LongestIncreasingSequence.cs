/*Write a program to find all increasing sequences inside an array of integers. The integers are given on a single line, separated by a space. Print the sequences in the order of their appearance in the input array, each at a single line. Separate the sequence elements by a space. Find also the longest increasing sequence and print it at the last line. If several sequences have the same longest length, print the left-most of them.*/

namespace _05.LongestIncreasingSequence
{
    using System;
    using System.Linq;

    class LongestIncreasingSequence
    {
        static void Main()
        {
            Console.WriteLine("Please, enter a sequence of integers, all in one line, separated by a space:");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numberLongest = 0;
            int bestCount = 0;
            int longestCount = 0;
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                int count = GetLongestSequence(i, array);

                if (count >= bestCount)
                {
                    bestCount = count;
                    int number = i;
                    i += count - 1;

                    PrintSequence(number, bestCount, array);

                    if (bestCount > longestCount)
                    {
                        longestCount = bestCount;
                        numberLongest = number;
                    }
                    bestCount = 0;
                }
            }
            Console.Write("Longest: ");
            PrintSequence(numberLongest, longestCount, array);
        }

        private static void PrintSequence(int number, int bestCount, int[] array)
        {
            for (int l = number; l <= number + bestCount - 1; l++)
            {
                Console.Write("{0} ", array[l]);
            }
            Console.WriteLine();
        }

        private static int GetLongestSequence(int i, int[] array)
        {
            int count = 1;
            int j = i + 1;
            int k = i;
            while (array[k] < array[j])
            {
                count++;
                j++;
                k++;
                if (j >= array.Length)
                {
                    break;
                }
            }
            return count;
        }
    }
}