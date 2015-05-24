/* Implement the "Falling Rocks" game in the text console. A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys). A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
Implement collision detection and scoring system.*/

namespace FallingRocks
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;

    internal struct Object
    {
        public int x;
        public int y;
        public string a;
        public char c;
        public ConsoleColor Color;
    }

    internal class FallingRocks
    {
        private static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.WriteLine(c);
        }

        private static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Cyan)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.WriteLine(str);
        }

        private static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            int PlayfieldWidth = 20;
            int scores = 0;
            var livesCount = 5;
            string arrows = "← →";
            string arrows2 = "↕";
            Console.BufferHeight = Console.WindowHeight = 25; // redove
            Console.BufferWidth = Console.WindowWidth = 60;
            Object userObject = new Object();
            userObject.x = 10;
            userObject.y = Console.WindowHeight - 1;
            userObject.a = "(O)";
            userObject.Color = ConsoleColor.Yellow;
            Random randomGenerator = new Random();
            List<Object> objects = new List<Object>();

            // Move our dwarf (key pressed)
            while (true)
            {
                bool hitted = false;
                {
                    int chance = randomGenerator.Next(0, 100);
                    if (chance < 40)
                    {
                        Object newObject = new Object();
                        newObject.Color = ConsoleColor.Red;
                        newObject.c = '#';
                        newObject.x = randomGenerator.Next(0, PlayfieldWidth);
                        newObject.y = 0;
                        objects.Add(newObject);
                    }
                    if (chance < 40)
                    {
                        Object newObject = new Object();
                        newObject.Color = ConsoleColor.Cyan;
                        newObject.c = '!';
                        newObject.x = randomGenerator.Next(0, PlayfieldWidth);
                        newObject.y = 0;
                        objects.Add(newObject);
                    }
                    if (chance < 40)
                    {
                        Object newObject = new Object();
                        newObject.Color = ConsoleColor.Green;
                        newObject.c = '%';
                        newObject.x = randomGenerator.Next(0, PlayfieldWidth);
                        newObject.y = 0;
                        objects.Add(newObject);
                    }
                    if (chance < 40)
                    {
                        Object newObject = new Object();
                        newObject.Color = ConsoleColor.White;
                        newObject.c = '@';
                        newObject.x = randomGenerator.Next(0, PlayfieldWidth);
                        newObject.y = 0;
                        objects.Add(newObject);
                    }
                    else if (chance < 40)
                    {
                        Object newObject = new Object();
                        newObject.Color = ConsoleColor.Yellow;
                        newObject.c = '*';
                        newObject.x = randomGenerator.Next(0, PlayfieldWidth);
                        newObject.y = 0;
                        objects.Add(newObject);
                    }
                    if (chance < 40)
                    {
                        Object newObject = new Object();
                        newObject.Color = ConsoleColor.Blue;
                        newObject.c = '&';
                        newObject.x = randomGenerator.Next(0, PlayfieldWidth);
                        newObject.y = 0;
                        objects.Add(newObject);
                    }
                    else
                    {
                        Object newObject = new Object();
                        newObject.Color = ConsoleColor.Magenta;
                        newObject.c = '$';
                        newObject.x = randomGenerator.Next(0, PlayfieldWidth);
                        newObject.y = 0;
                        objects.Add(newObject);
                    }
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey();
                    }
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (userObject.x - 1 >= 0)
                        {
                            userObject.x--;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (userObject.x + 1 < PlayfieldWidth)
                        {
                            userObject.x = userObject.x + 1;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.UpArrow)
                    {
                        if (userObject.y - 1 >= 0)
                        {
                            userObject.y--;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.DownArrow)
                    {
                        if (userObject.y + 1 >= 0)
                        {
                            userObject.y = userObject.y + 1;
                        }
                    }
                }

                // Move rocks
                List<Object> newList = new List<Object>();
                for (int i = 0; i < objects.Count; i++)
                {
                    Object oldObject = objects[i];
                    Object newObject = new Object();
                    newObject.x = oldObject.x;
                    newObject.y = oldObject.y + 1;
                    newObject.c = oldObject.c;
                    newObject.Color = oldObject.Color;
                    objects.Remove(oldObject);
                    if (newObject.c == '#' && newObject.y == userObject.y && newObject.x == userObject.x)
                    {
                        livesCount--;
                        hitted = true;
                    }
                    if (newObject.c == '!' && newObject.y == userObject.y && newObject.x == userObject.x)
                    {
                        scores++;
                    }
                    if (newObject.c == '$' && newObject.y == userObject.y && newObject.x == userObject.x)
                    {
                        scores++;
                    }
                    if (newObject.c == '&' && newObject.y == userObject.y && newObject.x == userObject.x)
                    {
                        scores++;
                    }
                    if (newObject.c == '%' && newObject.y == userObject.y && newObject.x == userObject.x)
                    {
                        scores++;
                    }
                    if (newObject.c == '@' && newObject.y == userObject.y && newObject.x == userObject.x)
                    {
                        scores++;
                    }
                    if (newObject.c == '*' && newObject.y == userObject.y && newObject.x == userObject.x)
                    {
                        scores++;
                    }
                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(32, 5, "YOU LOSE", ConsoleColor.Red);
                        PrintStringOnPosition(32, 6, "Press [enter] to continue", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    if (newObject.y < Console.WindowHeight)
                    {
                        newList.Add(newObject);
                    }
                    objects.Add(newObject);
                }
                objects = newList;

                // Clear the console
                Console.Clear();
                // Redraw playfield

                foreach (Object rock in newList)
                {
                    PrintOnPosition(rock.x, rock.y, rock.c, rock.Color);
                }
                if (hitted)
                {
                    objects.Clear();
                    PrintOnPosition(userObject.x, userObject.y, 'X', ConsoleColor.Red);
                }
                else
                {
                    PrintStringOnPosition(userObject.x, userObject.y, userObject.a, userObject.Color);
                }
                // Draw info
                PrintStringOnPosition(32, 2, "Lives: " + livesCount, ConsoleColor.Cyan);
                PrintStringOnPosition(32, 4, "Scores: " + scores, ConsoleColor.White);
                PrintStringOnPosition(32, 6, "Press " + arrows + " and " + arrows2 + " to move", ConsoleColor.Yellow);

                // Slow down program
                Thread.Sleep(150);
            }
        }
    }
}


