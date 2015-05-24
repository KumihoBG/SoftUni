﻿/*Write a program which reads a string matrix from the console and performs certain operations with its elements. User input is provided like in the problem above – first you read the dimensions and then the data. Remember, you are not required to do this step first, you may add this functionality later.  
Your program should then receive commands in format: "swap x1 y1 x2 y2" where x1, x2, y1, y2 are coordinates in the matrix. In order for a command to be valid, it should start with the "swap" keyword along with four valid coordinates (no more, no less). You should swap the values at the given coordinates (cell [x1, y1] with cell [x2, y2]) and print the matrix at each step (thus you'll be able to check if the operation was performed correctly). 
If the command is not valid (doesn't contain the keyword "swap", has fewer or more coordinates entered or the given coordinates do not exist), print "Invalid input!" and move on to the next command. Your program should finish when the string "END" is entered.*/

namespace _03.MatrixShuffling
{
    using System;

    class MatrixShuffling
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rows, cols];
            FillMatrix(matrix, rows, cols);
            SwapCycle(matrix);
        }

        static void FillMatrix(string[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int l = 0; l < cols; l++)
                {
                    matrix[i, l] = Console.ReadLine();
                }
            }
        }

        static void SwapCycle(string[,] matrix)
        {
            string action = Console.ReadLine();
            while (action != "END")
            {
                string[] commands = action.Split();
                if (ConditionCheck(commands, matrix))
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine();
                }
                else
                {
                    int x1 = int.Parse(action.Split()[1]);
                    int y1 = int.Parse(action.Split()[2]);
                    int x2 = int.Parse(action.Split()[3]);
                    int y2 = int.Parse(action.Split()[4]);

                    //methods
                    Swap(matrix, x1, y1, x2, y2);
                    Print(matrix);

                }
                action = Console.ReadLine();
            }
        }

        static bool ConditionCheck(string[] commands, string[,] matrix)
        {
            if (commands.Length != 5 || commands[0] != "swap")
            {
                return true;
            }
            else
            {
                for (int i = 1; i < 5; i++)
                {
                    int x;
                    bool isValid = int.TryParse(commands[i], out x);
                    if (isValid == false || x < 0 ||
                        ((i == 1 || i == 3) && x > matrix.GetUpperBound(0)) ||
                        ((i == 2 || i == 4) && x > matrix.GetUpperBound(1)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static void Swap(string[,] matrix, int x1, int y1, int x2, int y2)
        {
            string temp = matrix[x1, y1];
            matrix[x1, y1] = matrix[x2, y2];
            matrix[x2, y2] = temp;
        }

        static void Print(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    Console.Write("{0} ", matrix[i, l]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
