/* Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).*/

namespace QuadraticEquation
    {
    using System;
    using System.Threading;
    using System.Globalization;

    class QuadraticEquation
        {
        static void Main()
            {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please, enter the coefficient \"a\": ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please, enter the coefficient \"b\": ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please, enter the coefficient \"c\": ");
            double c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            if (d < 0)                                          // using if-else statement
                {
                Console.WriteLine("There are no real roots!");
                }
            else
                {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Two real roots: {0} or  {1}", x1, x2);
                }
            }
        }
    }

