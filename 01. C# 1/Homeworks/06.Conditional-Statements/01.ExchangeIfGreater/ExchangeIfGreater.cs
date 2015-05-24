// Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space;

namespace ExchangeIfGreater
    {
    using System;
    using System.Globalization;
    using System.Threading;

    class ExchangeIfGreater
        {
        static void Main()
            {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please, enter double \"a\": ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Now, enter double \"b\": ");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
                {
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine("The two double variables are the following: {0} {1}.", a, b);
                }
            else
                {
                Console.WriteLine("{0} {1}", a, b);
                Console.WriteLine("Result: the second number is greater than the first one!");
                }
            }
        }
    }
