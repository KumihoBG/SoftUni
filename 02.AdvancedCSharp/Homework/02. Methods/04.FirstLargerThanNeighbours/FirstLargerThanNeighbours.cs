/*Write a method that returns the index of the first element in array that is larger than its neighbours, or -1 if there's no such element. Use the method from the previous exercise in order to re.*/

namespace _04.FirstLargerThanNeighbours
    {
    using System;

    class FirstLargerThanNeighbours
        {
        static void Main()
            {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };

            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
            }

        private static int GetIndexOfFirstElementLargerThanNeighbours(int[] sequence)
            {
            for (int i = 0; i < sequence.Length; i++)
                {
                if (IsLargerThanNeighbors(sequence, i))
                    {
                    return i;
                    }
                }

            return -1;
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
