﻿/*Write a program to read an array of numbers from the console, sort them and print them back on the console. The numbers should be entered from the console on a single line, separated by a space*/

namespace _01.SortArrayOfNumbers
{
    using System;
    using System.Linq;

    class SortArrayOfNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter the values of the array numbers on a single line, separated by space or comma: ");

            int[] arrInts = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Array.Sort(arrInts);
            Console.WriteLine(string.Join(" ", arrInts));
        }
    }
}