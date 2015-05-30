using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Parachute___List__strings
    {
    class Parachute
        {
        static void Main()
            {
            List<string> lines = new List<string>();

            // input
            int counter = 0;
            int playerRow = 0;
            int playerCol = 0;

            string line = Console.ReadLine(); // reading first line separately as it doesn't affect the wind direction
            lines.Add(line);

            while (true)
                {
                // checking for start row/col
                playerCol = CheckForStartPoint(line, playerCol, counter, ref playerRow);

                // reading next line
                line = Console.ReadLine();

                if (line == "END")
                    {
                    break;
                    }

                lines.Add(line);
                counter++;
                }

            while (true)
                {
                // falling down until an obstacle is reached
                playerRow++;
                // calculating the total direction of the wind 
                playerCol = CalculateAndApplyWindDirection(lines, playerRow, playerCol);

                // switching obstacles (if reached)
                if (CheckForObstacles(lines, playerRow, playerCol)) return;
                }
            }

        private static bool CheckForObstacles(List<string> lines, int playerRow, int playerCol)
            {
            switch (lines[playerRow][playerCol])
                {
                case '_':
                    Console.WriteLine("Landed on the ground like a boss!");
                    Console.WriteLine("{0} {1}", playerRow, playerCol);
                    return true;
                case '~':
                    Console.WriteLine("Drowned in the water like a cat!");
                    Console.WriteLine("{0} {1}", playerRow, playerCol);
                    return true;
                case '\\':
                case '/':

                case '|':
                    Console.WriteLine("Got smacked on the rock like a dog!");
                    Console.WriteLine("{0} {1}", playerRow, playerCol);
                    return true;
                }
            return false;
            }

        private static int CalculateAndApplyWindDirection(List<string> lines, int playerRow, int playerCol)
            {
            int left = lines[playerRow].Count(f => f == '<');
            int right = lines[playerRow].Count(f => f == '>');
            playerCol += right - left;
            return playerCol;
            }

        private static int CheckForStartPoint(string line, int playerCol, int counter, ref int playerRow)
            {
            int index = line.IndexOf("o", StringComparison.Ordinal);
            if (index > playerCol)
                {
                playerCol = index;
                playerRow = counter;
                }
            return playerCol;
            }
        }
    }
