// Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
// The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

using System;

namespace MinMaxSumAverageOfNNumbers
    {
    class MinMaxSumNumbers
        {
        static void Main()
            {
            Console.WriteLine("Enter the lenght of the sequence: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 1; i <= n; i++)
                {
                Console.Write("Now enter the {0} number: ", i);
                int input = int.Parse(Console.ReadLine());

                sum += input;
                if (input > max)
                    {
                    max = input;
                    }
                if (input < min)
                    {
                    min = input;
                    }
                }
            double avg = (double)sum / n;
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:F2}", avg);
            }
        }
    }
