namespace _10.Headphones
    {
    using System;

    class Headphones
        {
        static void Main()
            {
            int size = int.Parse(Console.ReadLine());
            int width = 2 * size + 1;
            int height = 2 * size;
            int stars = 1;
            int lowerDash = size / 2;
            int middleDash = size;

            string line = new string('-', size / 2) + new string('*', size + 2) + new string('-', size / 2);
            Console.WriteLine(line);

            for (int i = 0; i < size - 1; i++)
                {
                line = new string('-', size / 2) + "*" + new string('-', size) + "*" + new string('-', size / 2);
                Console.WriteLine(line);
                }

            for (int i = 0; i < size / 2; i++)
                {
                line = new string('-', lowerDash) + new string('*', stars) + new string('-', middleDash) + new string('*', stars) + new string('-', lowerDash);
                stars += 2;
                middleDash -= 2;
                lowerDash--;
                Console.WriteLine(line);
                }

            for (int i = 0; i < size / 2; i++)
                {
                line = new string('-', lowerDash) + new string('*', stars) + new string('-', middleDash) + new string('*', stars) + new string('-', lowerDash);
                stars -= 2;
                middleDash += 2;
                lowerDash++;
                Console.WriteLine(line);
                }
            line = new string('-', size / 2) + "*" + new string('-', size) + "*" + new string('-', size / 2);
            Console.WriteLine(line);
            }
        }
    }
