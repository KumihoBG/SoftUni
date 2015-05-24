/*Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and output lists are given as integers, separated by a space, each list at a separate line. */

namespace _10.JoinLists
    {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class JoinLists
        {
        static void Main()
            {
            Console.WriteLine("Please, enter first list of numbers in one line, separated by a space: ");
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine("Please, enter second list of numbers in one line, separated by a space: ");
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> result = firstList.Union(secondList).ToList();
            result.Sort();
            Console.WriteLine("The lists after joining them: ");
            Console.WriteLine("{0}", string.Join(" ", result));
            }
        }
    }
