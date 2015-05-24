/*Write two programs that fill and print a matrix of size N x N. Filling a matrix in the regular pattern (top to bottom and left to right) is boring. */

namespace _01.FillTheMatrix
{
    using System;

    class FillTheMatrix
    {
        static void Main()
        {
            Console.Write("Enter the number of the rows of the matrix: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of the columns of the matrix: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            int counter = 1; // using a counter to fill the cells of the matrix
            Console.WriteLine();
            Console.WriteLine(new string('*', 20));

            // variant A
            for (int row = 0; row < matrix.GetLength(0); row++) // by rows
            {
                for (int col = 0; col < matrix.GetLength(1); col++) // by columns
                {
                    matrix[row, col] = counter; // increasing the counter to fill it on each turn of the loop
                    counter++;
                }
            }

            // Printing the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,4}", matrix[col, row]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine(new string('*', 20));

            // variant B
            int[,] matrixTwo = new int[rows, cols];

            int counterTwo = 1;

            for (int col = 0; col < matrixTwo.GetLength(1); col++)
            {
                if (col % 2 == 0) // if we have an odd columns, we do the following
                {
                    for (int row = 0; row < rows; row++) // from zero to the row number
                    {
                        matrixTwo[col, row] = counterTwo; // our matrix fills its cells
                        counterTwo++;  // increasing the counting number on each turn
                    }
                }
                else  // else, if we have an even columns
                {
                    for (int row = matrixTwo.GetLength(0) - 1; row >= 0; row--)
                    {
                        matrixTwo[col, row] = counterTwo;
                        counterTwo++;
                    }
                }
            }

            //Printing the matrix
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    Console.Write("{0, 4}", matrixTwo[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
