/*Write a program that reads a number n and a sequence of n integers, sorts them and prints them. */

namespace _05.SortingNumbers
{
    using System;

    internal class SortingNumbers
    {
        private static void Main()
        {
            Console.WriteLine("Enter the number \"n\", followed by the sequence of integers: ");
            int n = int.Parse(Console.ReadLine());
            int[] newArray = new int[n];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(newArray);

            Console.WriteLine("Printing the sorted array of numbers:");
            int j;
            for (j = 0; j < newArray.Length; j++) // printing the sorted array
            {
                if (j != newArray.Length - 1)
                {
                    Console.Write(newArray[j] + " ");
                }
                else
                {
                    Console.WriteLine(newArray[j]);
                }
            }
        }
    }
}
