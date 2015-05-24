/* Write a program that reads 3 real numbers from the console and prints their sum. */

namespace SumOfThreeNumbers
{
    using System;
    using System.Globalization;
    using System.Threading;

    class SumOfNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please, enter number \"a\": ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter number \"b\": ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter number \"c\": ");
            double c = double.Parse(Console.ReadLine());
            double sum = a + b + c;
            Console.WriteLine("The sum of these three numbers is: " + sum);
        }
    }
}
