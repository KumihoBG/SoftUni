// Write a program that enters 3 real numbers and prints them sorted in descending order;
// Note: Don’t use arrays and the built-in sorting functionality; Use nested Ifs;

namespace SortThreeNumbersWithNestedIfs
    {
    using System;
    using System.Threading;
    using System.Globalization;

    internal class SortThreeNumbers
        {
        private static void Main()
            {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please, enter \"a\": ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please, enter \"b\": ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please, enter \"c\": ");
            double c = double.Parse(Console.ReadLine());

            if (a >= b && a >= c)
                {
                if (b > c)
                    {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                    }
                else
                    {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                    }
                }
            else if (b >= a && b >= c)
                {
                if (a > c)
                    {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                    }
                else
                    {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                    }
                }
            else if (c >= a && c >= b)
                {
                if (a > b)
                    {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                    }
                else
                    {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                    }
                }
            }
        }
    }


