/*Problem. 10. Point Inside a Circle & Outside of a Rectangle
Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).*/

using System;
using System.Globalization;
using System.Threading;

class PointInsideACircle
    {
    static void Main()
        {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter x: ");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        decimal y = decimal.Parse(Console.ReadLine());
        const decimal radius = 1.5m;
        bool isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= radius * radius;
        if (isInCircle && y > 1)
            {
            Console.WriteLine("yes");
            }
        else
            {
            Console.WriteLine("no");
            }
        }
    }
