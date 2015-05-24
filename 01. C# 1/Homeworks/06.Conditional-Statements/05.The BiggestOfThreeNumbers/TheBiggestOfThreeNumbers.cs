// Write a program that finds the biggest of three numbers;

namespace TheBiggestOfThreeNumbers
    {
    using System;
    using System.Threading;
    using System.Globalization;
    using System.Linq;

    class TheBiggestOfThreeNumbers
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

            double[] biggerNumber = { a, b, c };              // using an array;
            double numberMax = biggerNumber.Max();          // must add System.Linq in order to use .Max();
            Console.WriteLine(numberMax);                   // just printing the result;
            }
        }
    }
