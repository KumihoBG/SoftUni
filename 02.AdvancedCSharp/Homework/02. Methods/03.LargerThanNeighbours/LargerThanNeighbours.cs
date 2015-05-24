/*Write a method that checks if the element at given position in a given numbers of integers is larger than its two neighbours (when such exist).*/

namespace _03.LargerThanNeighbours
    {
    using System;

    internal class LargerThanNeighbours
        {
        private static void Main()
            {

            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

            for (int position = 0; position < numbers.Length; position++)
                {
                Console.WriteLine(IsLargerThanNeighbors(numbers, position));
                }
            }

        private static bool IsLargerThanNeighbors(int[] numbers, int position)
            {
            bool isLarger;

            if (position == 0)
                {
                isLarger = numbers[position + 1] < numbers[position];
                }
            else if (position > 0 && position < numbers.Length - 1)
                {
                isLarger = numbers[position - 1] < numbers[position] && numbers[position + 1] < numbers[position];
                }
            else
                {
                isLarger = numbers[position - 1] < numbers[position];
                }

            return isLarger;
            }
        }
    }
