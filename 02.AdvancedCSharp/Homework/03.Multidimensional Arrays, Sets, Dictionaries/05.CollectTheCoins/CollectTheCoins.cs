/*Working with multidimensional arrays can be (and should be) fun. Let's make a game out of it.
You receive the layout of a board from the console. Assume it will always have 4 rows which you'll get as strings, each on a separate line. Each character in the strings will represent a cell on the board. Note that the strings may be of different length.
You are the player and start at the top-left corner (that would be position [0, 0] on the board). On the fifth line of input you'll receive a string with movement commands which tell you where to go next, it will contain only these four characters – '>' (move right), '<' (move left), '^' (move up) and 'v' (move down). 
You need to keep track of two types of events – collecting coins (represented by the symbol '$', of course) and hitting the walls of the board (when the player tries to move off the board to invalid coordinates). When all moves are over, print the amount of money collected and the number of walls hit.*/

namespace _05.CollectTheCoins
{
    using System;

    class CollectTheCoins
    {
        static void Main()
        {
            string[] board = new string[4];
            for (int i = 0; i < 4; i++)
            {
                board[i] = Console.ReadLine();
            }
            char[] commands = Console.ReadLine().ToCharArray();

            int x = 0;
            int y = 0;
            int coins = 0;
            int hits = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case '>':
                        int temp = y + 1;
                        if (temp < board[x].Length)
                        {
                            y = temp;
                            if (board[x][y] == '$')
                            {
                                coins++;
                            }
                        }
                        else
                        {
                            hits++;
                        }
                        break;

                    case '<':
                        temp = y - 1;
                        if (temp >= 0)
                        {
                            y = temp;
                            if (board[x][y] == '$')
                            {
                                y = temp;
                                coins++;
                            }
                        }
                        else
                        {
                            hits++;
                        }
                        break;

                    case '^':
                        temp = x - 1;
                        if (temp >= 0)
                        {
                            x = temp;
                            if (board[x][y] == '$')
                            {
                                coins++;
                            }
                        }
                        else
                        {
                            hits++;
                        }
                        break;

                    case 'v':
                        temp = x + 1;
                        if (temp < 4)
                        {
                            x = temp;
                            if (board[x][y] == '$')
                            {
                                coins++;
                            }
                        }
                        else
                        {
                            hits++;
                        }
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The board:");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write("{0}\n", board[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Coins collected: {0}", coins);
            Console.WriteLine("Walls hit: {0}", hits);
        }
    }
}
