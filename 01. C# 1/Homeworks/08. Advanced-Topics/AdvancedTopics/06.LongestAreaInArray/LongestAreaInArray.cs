/*Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings (each at a separate line), then find and print the longest sequence of equal elements (first its length, then its elements). If multiple sequences have the same maximal length, print the leftmost of them.*/

namespace _06.LongestAreaInArray
    {
    using System;
    using System.Collections.Generic;

        class LongestAreaInArray
        {
        static void Main()
            {
            int n = int.Parse(Console.ReadLine());
            List<string> sequence = new List<string>();

            string[] arr = new string[n];
            int i;
            for (i = 0; i < arr.Length; i++)
                {
                arr[i] = Console.ReadLine();
                }
            Console.WriteLine();
            sequence = LongestSequence(arr);
            Console.WriteLine("The lenght of the sequence is: {0}", sequence.Count);
            Console.WriteLine("The longest sequence has the following elements:");
            for (int k = 0; k < sequence.Count; k++)
                {
                Console.WriteLine(sequence[k]);
                }
            }

        private static List<string> LongestSequence(string[] array)
            {
            List<string> longestSequence = new List<string>();
            string str = array[0];
            int count = 1;
            int bestCount = 1;

            for (int i = 0; i < array.Length - 1; i++)
                {
                if (array[i] == array[i + 1])
                    {
                    count++;
                    if (count > bestCount)
                        {
                        bestCount = count;
                        str = array[i];
                        }
                    }
                else
                    {
                    count = 1;
                    }
                }

            for (int j = 0; j < bestCount; j++)
                {
                longestSequence.Add(str);
                }

            return longestSequence;
            }
        }
    }
