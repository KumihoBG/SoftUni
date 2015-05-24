//Problem 7. Point in a Circle
//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;
using System.Globalization;
using System.Threading;

class PointInACircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter x: ");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        decimal y = decimal.Parse(Console.ReadLine());
        const byte radius = 2;
        bool isInCircle = x * x + y * y <= radius * radius;
        Console.WriteLine("Is the point in the circle? {0}", isInCircle);
    }
}