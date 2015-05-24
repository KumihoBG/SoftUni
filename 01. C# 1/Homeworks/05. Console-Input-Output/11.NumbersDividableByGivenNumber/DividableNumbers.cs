/* Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0. */

namespace NumbersDividableByGivenNumber
    {
    using System;
    using System.Threading;
    using System.Globalization;

    class DividableNumbers
        {
        static void Main()
            {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please, enter the starting number: ");
            double positiveOne = double.Parse(Console.ReadLine());
            Console.Write("Please, enter the ending number: ");
            double positiveTwo = double.Parse(Console.ReadLine());

            if (positiveOne > 0 && positiveTwo > 0)                    // numbers should be positive
                {
                for (int i = 0; i <= positiveTwo; i++)            // max number is the ending one
                    {
                    if (i > positiveOne && i % 5 == 0)      // i should be greater than the starting number
                        {                                       // i should be dividable by 5 with reminder 0
                        Console.Write(i + " ");            // printing the result
                        }
                    }
                }
            else
                {
                // in case some of these numbers are not positive
                Console.WriteLine("Some of these numbers are not positive!");
                }
            if (positiveOne > positiveTwo)
                {
                // in case the starting number is bigger than the ending one
                Console.WriteLine("The starting number should be smaller than the ending one. Try again!");
                }
            }
        }
    }
