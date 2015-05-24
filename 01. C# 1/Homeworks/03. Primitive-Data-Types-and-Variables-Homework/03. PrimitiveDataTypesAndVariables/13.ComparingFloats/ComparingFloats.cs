/* Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.*/

namespace _13.ComparingFloats
    {
    using System;
    using System.Globalization;
    using System.Threading;

    class ComparingFloats
        {
        static void Main()
            {
            CultureInfo en = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = en;

            const double epsPrecision = 0.000001;
            Console.WriteLine("Enter the first floating number: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second floating number: ");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Abs(a - b);

            Console.WriteLine(c > epsPrecision ? "False" : "True");
            }
        }
    }
