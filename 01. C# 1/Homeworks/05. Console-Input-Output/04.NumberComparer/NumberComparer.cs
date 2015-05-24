/* Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements. */

namespace NumberComparer
{
    using System;
    using System.Threading;
    using System.Globalization;

    class NumberComparer
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please, enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please, enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            double greatNumber = Math.Max(a, b);
            Console.WriteLine("The greater number is {0}", greatNumber);
         }
     }
}
