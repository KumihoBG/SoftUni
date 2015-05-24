namespace _08.Dumbbell
    {
    using System;

    class Dumbbell
        {
        static void Main()
            {
            int size = int.Parse(Console.ReadLine());
            int width = 3 * size;
            int stars = size / 2;
            int lowerStars = size - 3;
            int outerDots = 1;
            string line = new string('.', size / 2) + new string('&', size / 2 + 1) + new string('.', size) +
                          new string('&', size / 2 + 1) + new string('.', size / 2);
            Console.WriteLine(line);
            for (int i = 1; i <= size / 2 - 1; i++)
                {
                line = new String('.', (size / 2) - i) + "&" + new string('*', stars) + "&" +
                       new String('.', size) + "&" + new string('*', stars) + "&" + new string('.', (size / 2) - i);
                stars++;
                Console.WriteLine(line);
                }
            line = "&" + new string('*', size - 2) + "&" + new string('=', size) + "&" +
                   new string('*', size - 2) + "&";
            Console.WriteLine(line);
           
            for (int i = 1; i <= size / 2 - 1; i++)
                {
                line = new string('.', outerDots) + "&" + new string('*', lowerStars) + "&" +
                       new String('.', size) + "&" + new string('*', lowerStars) + "&" + new string('.', outerDots);
                lowerStars--;
                outerDots++;
                Console.WriteLine(line);
                }
            line = new string('.', size / 2) + new string('&', size / 2 + 1) + new string('.', size) +
                          new string('&', size / 2 + 1) + new string('.', size / 2);
            Console.WriteLine(line);
            }
        }
    }