namespace _15.NewHouse
    {
    using System;

    class NewHouse
        {
        static void Main()
            {
            int number = int.Parse(Console.ReadLine());
            int whiteSpace = number / 2;
            int limit = number / 2;
            int stars = 1;
            for (int i = 0; i < limit; i++)
                {
                Console.Write(new string('-', whiteSpace));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', whiteSpace));
                stars += 2;
                whiteSpace--;
                }
            Console.WriteLine(new string('*', number));

            for (int i = 0; i < number; i++)
                {
                Console.Write(new string('|', 1));
                Console.Write(new string('*', number - 2));
                Console.WriteLine(new string('|', 1));
                }
            }
        }
    }
