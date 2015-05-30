/*Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and output lists are given as integers, separated by a space, each list at a separate line. Do not use LINQ! This problems aims to help you exercise your algorithmic thinking and not how well you are familiar with built-in .NET functionalities. Use only arrays and lists.*/

namespace _07.JoinLists
    {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class JoinLists
        {
        static void Main()
            {
            List<int> firstList = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            List<int> secondList = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            List<int> mergedList = new List<int>();

            foreach (var number in firstList)
                {
                mergedList.Add(number);
                }

            foreach (var number in secondList)
                {
                mergedList.Add(number);
                }

            mergedList.Sort();

            var result = new List<int>();
            for (int i = 0; i < mergedList.Count; i++)
            {
            if (i == mergedList.Count - 1 || mergedList[i] != mergedList[i + 1])
                result.Add(mergedList[i]);
            }
            
            foreach (var number in result)
                {
                Console.Write(number + " ");
                }
            Console.WriteLine();
            }
        }
    }
