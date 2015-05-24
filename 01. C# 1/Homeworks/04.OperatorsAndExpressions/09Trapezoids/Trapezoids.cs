//Problem 9. Trapezoids
//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
using System.Globalization;
using System.Threading;

class Trapezoids
    {
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter a: ");
        decimal sideA = decimal.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        decimal sideB = decimal.Parse(Console.ReadLine());
        Console.Write("Enter h: ");
        decimal heightH = decimal.Parse(Console.ReadLine());
        decimal area = ((sideA + sideB) / 2) * heightH;
        Console.WriteLine("The area is: {0}", area);
        }
    }