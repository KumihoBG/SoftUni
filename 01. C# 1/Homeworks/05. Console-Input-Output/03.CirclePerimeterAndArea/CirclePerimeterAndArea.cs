/* Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. */

namespace CirclePerimeterAndArea
    {
    using System;
    using System.Threading;
    using System.Globalization;

    class CirclePerimeterAndArea
        {
        static void Main()
            {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Enter the radius \"r\": ");
            decimal r = decimal.Parse(Console.ReadLine());
            decimal pi = (decimal)Math.PI;
            decimal perimeter = 2 * pi * r;
            decimal area = pi * r * r;
            Console.WriteLine("The perimeter of the circle is: {0:F2}", perimeter);
            Console.WriteLine("The area of the circle is: {0:F2}", area);
            }
        }
    }
