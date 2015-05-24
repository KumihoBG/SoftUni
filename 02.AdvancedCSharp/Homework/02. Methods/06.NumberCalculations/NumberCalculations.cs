/* Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers. Overload the methods to work with numbers of type double and decimal.*/

namespace _06.NumberCalculations
    {
    using System;
    using System.Linq;

    class NumberCalculations
        {
        static void Main()
            {
            Console.WriteLine("Enter two sets of numbers, each on a single line, separated by space: ");
            Console.WriteLine("Doubles: ");
            double[] inputArray = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Console.WriteLine("Decimals: ");
            decimal[] inputArrayTwo = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            Console.WriteLine(new string('*', 65));

            Console.WriteLine("The minimum is:                  -> Decimal: {0,2} -> Double: {1,2}", Minimum(inputArray), Minimum(inputArrayTwo));
            Console.WriteLine("The maximum is:                  -> Decimal: {0,2} -> Double: {1,2}", Maximum(inputArray), Maximum(inputArrayTwo));
            Console.WriteLine("The average amount is:           -> Decimal: {0,2} -> Double: {1,2}", Average(inputArray), Average(inputArrayTwo));
            Console.WriteLine("The sum of these numbers is:     -> Decimal: {0,2} -> Double: {1,2}", Sum(inputArray), Sum(inputArrayTwo));
            Console.WriteLine("The product of these numbers is: -> Decimal: {0,2} -> Double: {1,2}", Product(inputArray), Product(inputArrayTwo));
            }
        //  Decimal - product method
        static decimal Product(decimal[] arr)
            {
            decimal product = 1;
            for (int i = 0; i < arr.Length; i++)
                {
                product *= arr[i];
                }
            return product;
            }

        // Double - Product method
        static double Product(double[] arr)
            {
            double product = 1;
            for (int i = 0; i < arr.Length; i++)
                {
                product *= arr[i];
                }
            return product;
            }

        // Decimal - Sum method
        static decimal Sum(decimal[] arr)
            {
            decimal sum = 0;
            for (int i = 0; i < arr.Length; i++)
                {
                sum += arr[i];
                }
            return sum;
            }

        // Double - Sum method
        static double Sum(double[] arr)
            {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
                {
                sum += arr[i];
                }
            return sum;
            }

        // Decimal - average method
        static decimal Average(decimal[] arr)
            {
            decimal average = 0;
            decimal sum = 0;
            for (int i = 0; i < arr.Length; i++)
                {
                sum += arr[i];
                }
            average = sum / arr.Length;
            return average;
            }

        // Decimal - average method
        static double Average(double[] arr)
            {
            double average = 0;
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
                {
                sum += arr[i];
                }
            average = sum / arr.Length;
            return average;
            }

        // Decimal - maximum method
        static decimal Maximum(decimal[] arr)
            {
            decimal max = decimal.MinValue;
            for (int i = 0; i < arr.Length; i++)
                {
                if (arr[i] > max)
                    {
                    max = arr[i];
                    }
                }
            return max;
            }

        // Double - maximum method
        static double Maximum(double[] arr)
            {
            double max = double.MinValue;
            for (int i = 0; i < arr.Length; i++)
                {
                if (arr[i] > max)
                    {
                    max = arr[i];
                    }
                }
            return max;
            }

        // Decimal - minimum method
        static decimal Minimum(decimal[] arr)
            {
            decimal min = decimal.MaxValue;
            for (int i = 0; i < arr.Length; i++)
                {
                if (arr[i] < min)
                    {
                    min = arr[i];
                    }
                }
            return min;
            }

        // Double - minimum method
        static double Minimum(double[] arr)
            {
            double min = double.MaxValue;
            for (int i = 0; i < arr.Length; i++)
                {
                if (arr[i] < min)
                    {
                    min = arr[i];
                    }
                }
            return min;
            }
        }
    }