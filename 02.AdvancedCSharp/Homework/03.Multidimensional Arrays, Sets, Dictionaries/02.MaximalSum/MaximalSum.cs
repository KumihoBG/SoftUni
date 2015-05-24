/*Write a program that reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. 
On the first line, you will receive the rows N and columns M. On the next N lines you will receive each row with its columns.
Print the elements of the 3 x 3 square as a matrix, along with their sum.*/

namespace _02.MaximalSum
{
    using System;
    using System.Linq;

    internal class MaximalSum
    {
        private static void Main()
        {
            Console.WriteLine("Enter rows and the cols of the matrix, on a single line, separated by a space: ");
            string input = Console.ReadLine();
            int[] n = input
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[][] insideInput = new int[n[0]][];

            for (int row = 0; row < n[0]; row++)
            {
                insideInput[row] = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
            }

            var matrix = To2D(insideInput);
            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < n[0] - 2; row++)
            {
                for (int col = 0; col < n[1] - 2; col++)
                {
                    var currentSum = CalculateSum(row, col, matrix);

                    if (currentSum > maxSum)
                    {
                        maxRow = row;
                        maxCol = col;
                        maxSum = currentSum;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine(new string('*', 15));
            Console.WriteLine("   Sum = {0}", maxSum);
            PrintMatrix(matrix, maxRow, maxCol);
        }

        private static void PrintMatrix(int[,] matrix, int maxRow, int maxCol)
        {
            for (int rows = maxRow; rows <= maxRow + 2; rows++)
            {
                for (int cols = maxCol; cols <= maxCol + 2; cols++)
                {
                    Console.Write("{0,4}", matrix[rows, cols]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int CalculateSum(int startRow, int startCol, int[,] matrix)
        {
            int sum = 0;
            for (int row = startRow; row < startRow + 3; row++)
            {
                for (int col = startCol; col < startCol + 3; col++)
                {
                    sum = sum + matrix[row, col];
                }
            }

            return sum;
        }

        static T[,] To2D<T>(T[][] source)
        {
            int firstDimension = source.Length;
            int secondDimension = source.GroupBy(row => row.Length).Single().Key;

            var result = new T[firstDimension, secondDimension];
            for (int i = 0; i < firstDimension; ++i)
            {
                for (int j = 0; j < secondDimension; ++j)
                {
                    result[i, j] = source[i][j];
                }
            }
            return result;
        }
    }
}
