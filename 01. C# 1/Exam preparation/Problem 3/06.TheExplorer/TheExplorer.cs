namespace _19.TheExplorer
    {
    using System;

    class TheExplorer
        {
        private static void Main()
            {
            int width = int.Parse(Console.ReadLine());
            int outLines = width / 2;
            int innerLines = 1;
            int lowerLines = 1;
            int innerLoweLines = width - 4; 
            int outerLines = (width - 3) / 2;
            const int star = 1;

            Console.Write(new string('-', outLines));
            Console.Write(new string('*', star));
            Console.WriteLine(new string('-', outLines));

            for (int i = 0; i < width / 2; i++)
                {
                Console.Write(new string('-', outerLines));
                Console.Write(new string('*', star));
                Console.Write(new string('-', innerLines));
                Console.Write(new string('*', star));
                Console.WriteLine(new string('-', outerLines));
                outerLines--;
                innerLines += 2;
                }

            for (int i = 0; i < width / 2 - 1; i++)
                {
                Console.Write(new string('-', lowerLines));
                Console.Write(new string('*', star));
                Console.Write(new string('-', innerLoweLines));
                Console.Write(new string('*', star));
                Console.WriteLine(new string('-', lowerLines));
                lowerLines++;
                innerLoweLines -= 2;
                }

            Console.Write(new string('-', outLines));
            Console.Write(new string('*', star));
            Console.WriteLine(new string('-', outLines));
            }
        }
    }
