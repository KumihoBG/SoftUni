﻿namespace _3.TextGravity
    {
    using System;
    using System.Security;
    using System.Text;

    public class TextGravity
        {
        static void Main()
            {
            // input - taking one line and filling a matrix with it
            int totalCols = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            // finding exactly how many rows will have the matrix
            int rows = text.Length / totalCols;

            // in case it has remainder, we add one row
            if (text.Length % totalCols != 0)
                {
                rows++;
                }

            // filling the matrix of chars
            char[,] matrix = new char[rows, totalCols];
            int currentCharIndex = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
                {
                for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                    // we add white space in case the text is shorter than the current index
                    if (currentCharIndex < text.Length)
                        {
                        matrix[row, col] = text[currentCharIndex];
                        currentCharIndex++;
                        }
                    else
                        {
                        matrix[row, col] = ' ';
                        }
                    }
                }

            for (int col = 0; col < matrix.GetLength(1); col++)
                {
                RunGravity(matrix, col);
                }

            StringBuilder output = new StringBuilder();
            output.Append("<table>");
            for (int row = 0; row < matrix.GetLength(0); row++)
                {
                output.Append("<tr>");
                for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                    output.AppendFormat("<td>{0}</td>",
                        SecurityElement.Escape(matrix[row, col].ToString()));
                    }

                output.Append("</tr>");
                }

            output.Append("</table>");

            Console.WriteLine(output.ToString());
            }

        // for each column
        static void RunGravity(char[,] matrix, int col)
            {
            while (true)
                {
                bool hasFallen = false;
                for (int row = 1; row < matrix.GetLength(0); row++)
                    {
                    char topChar = matrix[row - 1, col];
                    char currentChar = matrix[row, col];
                    if (currentChar == ' ' && topChar != ' ')
                        {
                        // swapping their places
                        matrix[row, col] = topChar;
                        matrix[row - 1, col] = ' ';
                        hasFallen = true;
                        }
                    }

                if (!hasFallen)
                    {
                    break;
                    }
                }
            }
        }
    }