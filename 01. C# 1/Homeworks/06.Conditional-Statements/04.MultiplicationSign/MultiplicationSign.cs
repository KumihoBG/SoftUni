// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it;
namespace MultiplicationSign
    {
    using System;
    using System.Threading;
    using System.Globalization;

    class MultiplicationSign
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

            if ((a > 0 && b > 0 && c > 0) ||
                (a > 0 && b < 0 && c < 0) ||
                (a < 0 && b < 0 && c > 0) ||
                (a < 0 && b > 0 && c < 0))
                {
                Console.WriteLine("+");
                }
            if ((a < 0 && b < 0 && c < 0) ||
                (a > 0 && b < 0 && c < 0) ||
                (a > 0 && b < 0 && c > 0) ||
                (a < 0 && b > 0 && c > 0))
                {
                Console.WriteLine("-");
                }
            if (a == 0 || b == 0 || c == 0)
                {
                Console.WriteLine("0");
                }
            }
        }
    }
