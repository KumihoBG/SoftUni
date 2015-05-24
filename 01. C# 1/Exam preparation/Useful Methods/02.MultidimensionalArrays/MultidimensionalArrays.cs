using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MultidimensionalArrays
{
    internal class MultidimensionalArrays
    {
        private static void Main()
        {
            // генериране на матрица: ******************************************************************
            Random rnd = new Random();
            int n = rnd.Next(4, 6);
            int m = rnd.Next(4, 6);

            string[] srcSeq = {"ha", "ho", "hi", "fo", "xx", "xxx"};

            n = rnd.Next(4, 6);
            m = rnd.Next(4, 6);
            string[,] matrix1 = new string[n, m];

            // попълване на матрица: *******************************************************************
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            int counter = 1; // using a counter to fill the cells of the matrix

            for (int row = 0; row < matrix.GetLength(0); row++) // by rows
            {
                for (int col = 0; col < matrix.GetLength(1); col++) // by columns
                {
                    matrix[row, col] = counter; // increasing the counter to fill it on each turn of the loop
                    counter++;
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++) // Printing the matrix
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,4}", matrix[col, row]);
                }
                Console.WriteLine();
            }

            // принтиране на матрица с обърнати четни редове:*******************************************
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col%2 == 0) // if we have an odd columns, we do the following
                {
                    for (int row = 0; row < rows; row++) // from zero to the row number
                    {
                        matrix[col, row] = counter; // our matrix fills its cells
                        counter++; // increasing the counting number on each turn
                    }
                }
                else // else, if we have an even columns
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--) // we start from 
                    {
                        // the end of the matrix to zero, decreasing
                        matrix[col, row] = counter;
                        counter++;
                    }
                }
            }

            // принтиране на матрица по диагонал от долу-ляво до горе-дясно: ***************************
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[,] matrix2 = new int[r, c];
            int counter1 = 1; // the filling number in the cells of the matrix
            int rowOne = matrix.GetLength(0) - 1;
            int colOne = 0;
            int startRow = matrix.GetLength(0) - 1;
            int startCol = 0;

            while (counter1 < r*c)
            {
                if (rowOne == (matrix.GetLength(0) - 1) && colOne < (matrix.GetLength(0) - 1)) //Filling matrix
                {
                    if (counter == 1) //the start is always 1
                    {
                        matrix[colOne, rowOne] = counter;
                    }
                    startRow--;
                    startCol = 0;
                    rowOne = startRow;
                    colOne = startCol;
                    counter1++;
                    matrix[colOne, rowOne] = counter1;

                    while (rowOne < (matrix.GetLength(0) - 1) && colOne < (matrix.GetLength(0) - 1))
                    {
                        rowOne++;
                        colOne++;
                        counter1++;
                        matrix[colOne, rowOne] = counter1;
                    }
                }
                if (rowOne <= (matrix.GetLength(0) - 1) && colOne == (matrix.GetLength(0) - 1))
                {
                    startRow = 0;
                    startCol++;
                    rowOne = startRow;
                    colOne = startCol;
                    counter1++;
                    matrix[colOne, rowOne] = counter1;

                    while (colOne < (matrix.GetLength(1) - 1))
                    {
                        colOne++;
                        rowOne++;
                        counter1++;
                        matrix[colOne, rowOne] = counter1;
                    }
                }
            }
            for (colOne = 0; colOne < c; colOne++) //Printing the matrix
            {
                for (rowOne = 0; rowOne < r; rowOne++)
                {
                    Console.Write("{0, 4}", matrix[rowOne, colOne]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Търсене на максимална сума в матрица: ***************************************************
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            int[,] matrix3 = new int[y, z];

            for (int row = 0; row < y; row++) //Filling the matrix
            {
                for (int col = 0; col < z; col++)
                {
                    matrix3[row, col] = int.Parse(Console.ReadLine());
                }
            }
            // Finding the maximal sum platform of size 3 x 3
            int bestSum = int.MinValue;
            for (int row = 0; row < matrix3.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix3.GetLength(1) - 2; col++)
                {
                    int sum = matrix3[row, col] + matrix3[row, col + 1] + matrix3[row, col + 2] +
                              matrix3[row + 1, col] + matrix3[row + 1, col + 1]
                              + matrix3[row + 1, col + 2] + matrix3[row + 2, col] + matrix3[row + 2, col + 1] +
                              matrix3[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }

            for (int row = 0; row < matrix3.GetLength(0); row++) //Printing the matrix
            {
                for (int col = 0; col < matrix3.GetLength(1); col++)
                {
                    Console.Write("{0,4}", matrix3[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(bestSum);
        }

        // клас Матрица - сумиране, изваждане, умножение на една матрица с друга: ******************
        private class MatrixClass
        {
            private int[,] matrix;

            public MatrixClass(int rows, int cols)
            {
                this.matrix = new int[rows, cols];
            }

            public int Rows
            {
                get { return this.matrix.GetLength(0); }
            }

            public int Columns
            {
                get { return this.matrix.GetLength(1); }
            }

            public static MatrixClass operator +(MatrixClass first, MatrixClass second)
            {
                MatrixClass result = new MatrixClass(first.Rows, first.Columns);
                for (int row = 0; row < first.Rows; row++)
                {
                    for (int col = 0; col < first.Columns; col++)
                    {
                        result[row, col] = first[row, col] + second[row, col];
                    }
                }
                return result;
            }

            public static MatrixClass operator -(MatrixClass first, MatrixClass second)
            {
                MatrixClass result = new MatrixClass(first.Rows, first.Columns);
                for (int row = 0; row < first.Rows; row++)
                {
                    for (int col = 0; col < first.Columns; col++)
                    {
                        result[row, col] = first[row, col] - second[row, col];
                    }
                }
                return result;
            }

            public static MatrixClass operator *(MatrixClass first, MatrixClass second)
            {
                MatrixClass result = new MatrixClass(first.Rows, first.Columns);
                for (int row = 0; row < first.Rows; row++)
                {
                    for (int col = 0; col < first.Columns; col++)
                    {
                        result[row, col] = first[row, col]*second[col, row];
                    }
                }
                return result;
            }

            public int this[int row, int col]
            {
                get { return this.matrix[row, col]; }
                set { this.matrix[row, col] = value; }
            }

            public override string ToString()
            {
                string result = null;
                for (int row = 0; row < this.Rows; row++)
                {
                    for (int col = 0; col < this.Columns; col++)
                    {
                        result += matrix[row, col] + " ";
                    }
                    result += Environment.NewLine;
                }
                return result;
            }
        }

        private class PrintMatrix
        {
            private static void Main()
            {
                MatrixClass matrix1 = new MatrixClass(3, 3);
                MatrixClass matrix2 = new MatrixClass(3, 3);
                Random randomGen = new Random();
                for (int i = 0; i < matrix1.Rows; i++)
                {
                    for (int j = 0; j < matrix2.Columns; j++)
                    {
                        matrix1[i, j] = randomGen.Next(15);
                        matrix2[i, j] = randomGen.Next(15);
                    }
                }
                Console.WriteLine(matrix1);
                Console.WriteLine(matrix2);
                Console.WriteLine(matrix1 + matrix2);
                Console.WriteLine(matrix1 - matrix2);
                Console.WriteLine(matrix1*matrix2);
            }
        }

        // "Depth-first-search" and "Breadth-first-search", търсене на подматрица с еднакви съседни елементи
        public class LargestAreaInMatrix
        {
            private static int[,] matrix =
            {
                {1, 3, 2, 2, 2, 4},
                {3, 3, 3, 2, 4, 4},
                {4, 3, 1, 2, 3, 3},
                {4, 3, 1, 3, 3, 1},
                {4, 3, 3, 3, 1, 1}
            };

            private static bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            private static int DepthFirstSearch(int row, int col, int value)
            {
                if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
                {
                    return 0;
                }
                if (visited[row, col])
                {
                    return 0;
                }
                if (matrix[row, col] != value)
                {
                    return 0;
                }
                visited[row, col] = true;

                return DepthFirstSearch(row, col + 1, value) + DepthFirstSearch(row, col - 1, value) +
                       DepthFirstSearch(row + 1, col, value) + DepthFirstSearch(row - 1, col, value) + 1;
            }

            private static void PrintResult()
            {
                int result = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        result = Math.Max(result, DepthFirstSearch(row, col, matrix[row, col]));
                    }
                }
                Console.WriteLine("The number of all equal elements is {0}", result);
            }

            private static void Main()
            {
                PrintResult();
            }
        }

    }
}


