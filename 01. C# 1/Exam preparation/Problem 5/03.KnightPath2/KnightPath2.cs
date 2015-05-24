using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.KnightPath2
    {
    class KnightPath2
        {
        static void Main()
            {
            int X = 7;
            int Y = 0;

            int[,] board = new int[8, 8]; // chess board
            board[Y, X] = 1; // initial position of the knight

            // the list will be storing all sets of incomming commands - in arrays
            List<string[]> directions = new List<string[]>();
            string[] commands = new string[2];
            string input = "";

            // read the input
            while (input != "stop")
                {
                input = Console.ReadLine();
                if (input != "stop")
                    {
                    commands = input.Split(' ').ToArray();
                    directions.Add(commands);
                    }
                }

            // apply all sets of commands
            foreach (string[] dir in directions)
                {
                Move(ref X, ref Y, board, dir);
                }

            // the chess field view is final
            // and we turn each row into a binary string
            List<string> results = new List<string>();
            List<int> numbers = new List<int>();
            StringBuilder tempStr = new StringBuilder();
            for (int row = 0; row < 8; row++)
                {
                for (int col = 0; col < 8; col++)
                    {
                    tempStr.Append(board[row, col]);
                    }
                results.Add(tempStr.ToString());
                tempStr.Clear();
                }

            // converting all binary rows into ints
            for (int i = 0; i < results.Count; i++)
                {
                int num = Convert.ToInt32(results[i], 2);
                numbers.Add(num);
                }
            // if the no int is > 0
            if (numbers.Max() == 0)
                {
                Console.WriteLine("[Board is empty]");
                }
            // else: printing all ints > 0
            else
                {
                for (int i = 0; i < numbers.Count; i++)
                    {
                    if (numbers[i] != 0)
                        {
                        Console.WriteLine(numbers[i]);
                        }
                    }
                }
            }
        // moving the knight
        private static void Move(ref int X, ref int Y, int[,] board, string[] commands)
            {
            int tempX = X;
            int tempY = Y;
            switch (commands[0])
                {
                case "left": tempX -= 2; break;
                case "right": tempX += 2; break;
                case "up": tempY -= 2; break;
                case "down": tempY += 2; break;
                }

            switch (commands[1])
                {
                case "left": tempX--; break;
                case "right": tempX++; break;
                case "up": tempY--; break;
                case "down": tempY++; break;
                }

            // applying the move only if it won't go out of the board
            if (tempX >= 0 && tempX <= 7 && tempY >= 0 && tempY <= 7)
                {
                X = tempX;
                Y = tempY;

                if (board[Y, X] == 1)
                    {
                    board[Y, X] = 0;
                    }
                else
                    {
                    board[Y, X] = 1;
                    }
                }
            }
        }
    }
