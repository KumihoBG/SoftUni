/*You are given two jagged arrays. Each array represents a Lego block containing integers. Your task is first to reverse the second jagged array and then check if it would fit perfectly in the first jagged array.*/
// credits to Katya Marincheva

namespace _08.LegoBlocks
    {
    using System;
    using System.Linq;

    class LegoBlocks
        {
        static void Main()
            {
            int N;
            int[][] first;
            int[][] second;

            GetInputN(out N, out first, out second);

            // checking if the arrays fit
            int cellsCount;
            var fitting = CheckIfArraysFit(first, second, N, out cellsCount);

            // output
            if (!fitting)
                {
                Console.WriteLine("The total number of cells is: {0}", cellsCount);
                }
            else
                {
                PrintMatrix(N, second, first);
                }
            }

        private static void GetInputN(out int N, out int[][] first, out int[][] second)
            {
            N = int.Parse(Console.ReadLine());
            first = new int[N][];
            second = new int[N][];
            char[] charSeparators = { ' ' };

            for (int i = 0; i < N; i++)
                {
                first[i] = Console.ReadLine()
                    .Split(charSeparators, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                }

            for (int i = 0; i < N; i++)
                {
                second[i] = Console.ReadLine()
                    .Split(charSeparators, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                }
            }

        private static void PrintMatrix(int N, int[][] second, int[][] first)
            {
            for (int i = 0; i < N; i++)
                {
                Array.Reverse(second[i]);
                Console.WriteLine("[{0}, {1}]", string.Join(", ", first[i]), string.Join(", ", second[i]));
                }
            }

        private static bool CheckIfArraysFit(int[][] first, int[][] second, int N, out int cellsCount)
            {
            int a = first[0].Length;
            int b = second[0].Length;
            int c = a + b;
            bool fitting = true;
            cellsCount = c;

            for (int i = 1; i < N; i++)
                {
                a = first[i].Length;
                b = second[i].Length;
                cellsCount += a + b;
                if (a + b != c)
                    {
                    fitting = false;
                    }
                }
            return fitting;
            }
        }
    }
