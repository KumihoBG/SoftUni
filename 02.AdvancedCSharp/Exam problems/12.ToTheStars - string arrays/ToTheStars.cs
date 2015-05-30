using System;
using System.Linq;

namespace _09.ToTheStars___string_arrays
    {
    class ToTheStars
        {
        static void Main()
            {
            // get stars info
            string[] star1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name1 = star1[0].ToLower();
            double x1 = double.Parse(star1[1]);
            double y1 = double.Parse(star1[2]);

            string[] star2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name2 = star2[0].ToLower();
            double x2 = double.Parse(star2[1]);
            double y2 = double.Parse(star2[2]);

            string[] star3 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name3 = star3[0].ToLower();
            double x3 = double.Parse(star3[1]);
            double y3 = double.Parse(star3[2]);

            // get Normandy info
            double[] nCoordinates = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();
            double nX = nCoordinates[0];
            double nY = nCoordinates[1];

            // get moves info
            int turns = int.Parse(Console.ReadLine());

            // apply the moves
            for (double i = nY; i <= nY + turns; i++)
                {
                bool insideRectangle1 = (nX >= x1 - 1) && (nX <= x1 + 1) && (i >= y1 - 1) && (i <= y1 + 1);
                bool insideRectangle2 = (nX >= x2 - 1) && (nX <= x2 + 1) && (i >= y2 - 1) && (i <= y2 + 1);
                bool insideRectangle3 = (nX >= x3 - 1) && (nX <= x3 + 1) && (i >= y3 - 1) && (i <= y3 + 1);

                if (insideRectangle1)
                    {
                    Console.WriteLine(name1);
                    }
                else if (insideRectangle2)
                    {
                    Console.WriteLine(name2);
                    }
                else if (insideRectangle3)
                    {
                    Console.WriteLine(name3);
                    }
                else
                    {
                    Console.WriteLine("space");
                    }
                }
            }
        }
    }
