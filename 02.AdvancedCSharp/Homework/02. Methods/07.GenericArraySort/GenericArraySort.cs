/*Write a method which takes an array of any type and sorts it. Use bubble sort or selection sort (your own implementation). You may re-use your code from a previous homework and modify it. 
Use a generic method (read in Internet about generic methods in C#). Make sure that what you're trying to sort can be sorted – your method should work with numbers, strings, dates, etc., but not necessarily with custom classes like Student.*/

namespace _07.GenericArraySort
    {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class GenericArraySort
        {
        static void Main()
            {
            int[] numbers = { 2, 5, 6, 10, 11, 4, 1, 1046, 67, 0, -45 };
            string[] strings = { "cat", "dog", "horse", "gorilla", "zebra", "white tiger", "elephant" };
            DateTime[] dates =
                    {
                        new DateTime(2056, 2, 17, 4, 34, 22), new DateTime(2015, 5, 5, 3, 45, 59), new DateTime(2013, 10, 20, 17, 32, 34),
                    };

            Console.WriteLine(SortArray(numbers));
            Console.WriteLine();
            Console.WriteLine(SortArray(strings));
            Console.WriteLine();
            Console.WriteLine(SortArray(dates));
            Console.WriteLine();
            }

        private static string SortArray<T>(IEnumerable<T> input)
            {
            List<T> originalInput = input.ToList();
            List<T> sortedInput = new List<T>();

            while (originalInput.Count != 0)
                {
                var result = originalInput.Min();
                sortedInput.Add(result);
                originalInput.Remove(result);
                }
            return PrintArray(sortedInput);
            }

        private static string PrintArray<T>(IEnumerable<T> sortedInput)
            {
            return string.Join(", ", sortedInput);
            }
        }
    }
