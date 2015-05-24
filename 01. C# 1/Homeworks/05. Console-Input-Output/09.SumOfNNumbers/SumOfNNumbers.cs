/* Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop. */

namespace SumOfNNumbers
    {
    using System;
    using System.Globalization;
    using System.Threading;

    class SumOfNNumbers
        {
        static void Main()
            {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please, enter n numbers to calculate their sum: ");
            double n = double.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < n; i++)
                {
                Console.Write("Enter {0} from {1} numbers = ", i + 1, n);
                double newNumber = double.Parse(Console.ReadLine());
                sum += newNumber;
                }
            Console.WriteLine("The sum of these numbers is: " + sum);
            }
        }
    }
