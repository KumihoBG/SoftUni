/* Ivaylo decided he needs a new house. Since he is not a structural engineer yet, you have to help him construct the building from the ground zero.
The roof is a triangle. The walls are straight vertical lines. The base is a straight horizontal line. The roof, the walls and the base of the house it build of '*'. Everything else is filled with '.' (see the examples below to catch the idea).
You will be given an odd integer N, representing the width and the height of the house. The roof’s top starts from the center (N+1)/2 and forms a triangle with base of width N. The roof’s height is (N+1)/2. The distance between the roofs’ end point and the walls of the building is N/4, rounded down to an integer number. See the examples below to understand better these formulas.*/

namespace _15.House
    {
    using System;

    class House
        {
        static void Main()
            {
            int number = int.Parse(Console.ReadLine());

            // single upper line
            Console.Write(new string('.', number / 2));
            Console.Write(new string('*', 1));
            Console.WriteLine(new string('.', number / 2));

            // the roof
            int outsideDots = number / 2 - 1;
            int insideDots = 1;

            while (outsideDots != 0)
                {
                Console.Write(new string('.', outsideDots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', insideDots));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('.', outsideDots));

                outsideDots--;
                insideDots += 2;
                }

            // bottom of the roof
            Console.WriteLine(new string('*', number));

            // the walls of the house
            int outsideLowerDots = number / 4;

            for (int i = number / 2 + 1; i < number - 1; i++)
                {
                Console.Write(new string('.', outsideLowerDots));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', number - 2 * outsideLowerDots - 2));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('.', outsideLowerDots));
                }

            //lower single line
            Console.Write(new string('.', outsideLowerDots));
            Console.Write(new string('*', number - 2 * outsideLowerDots));
            Console.WriteLine(new string('.', outsideLowerDots));
            }
        }
    }
