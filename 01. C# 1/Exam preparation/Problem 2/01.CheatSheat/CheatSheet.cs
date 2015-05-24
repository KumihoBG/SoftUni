namespace _02.CheatSheet
    {
    using System;

    internal class CheatSheet
        {
        private static void Main()
            {
            short rows = short.Parse(Console.ReadLine());
            short cols = short.Parse(Console.ReadLine());
            long verticalNumber = long.Parse(Console.ReadLine());
            long horizontalNumber = long.Parse(Console.ReadLine());

            for (long row = verticalNumber; row < verticalNumber + rows; row++)
                {
                for (long col = horizontalNumber; col < horizontalNumber + cols; col++)
                    {
                    Console.Write(row * col);

                    if (col < horizontalNumber + cols - 1)
                        {
                        Console.Write(' ');
                        }
                    }
                Console.WriteLine();
                }
            }
        }
    }