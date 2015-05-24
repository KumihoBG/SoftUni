// Write a program that finds the biggest of five numbers by using only five if statements;

namespace The_BiggestOfFiveNumbers
    {
    using System;
    using System.Threading;
    using System.Globalization;

    class TheBiggestOfFiveNumbers
        {
        static void Main()
            {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please, enter \"a\": ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please, enter \"b\": ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please, enter \"c\": ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Please, enter \"d\": ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Please, enter \"e\": ");
            double e = double.Parse(Console.ReadLine());

            double biggerNumber = a;
            if (a > b && a > c && a > d && a > e)
                {
                biggerNumber = a;
                }
            if (b >= a && b >= c && b >= d && b >= e)
                {
                biggerNumber = b;
                }
            if (c >= a && c >= b && c >= d && c >= e)
                {
                biggerNumber = c;
                }
            if (d >= a && d >= b && d >= c && d >= e)
                {
                biggerNumber = d;
                }
            if (e >= a && e >= b && e >= c && e >= d)
                {
                biggerNumber = e;
                }
            Console.WriteLine("The bigger number is {0}", biggerNumber);
            }
        }
    }
