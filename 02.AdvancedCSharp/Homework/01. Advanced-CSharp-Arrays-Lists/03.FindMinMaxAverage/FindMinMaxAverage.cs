/*Write a program that reads N floating-point numbers from the console. Your task is to separate them in two sets, one containing only the round numbers (e.g. 1, 1.00, etc.) and the other containing the floating-point numbers with non-zero fraction. Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places).*/

namespace _03.FindMinMaxAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FindMinMaxAverage
    {
        static void Main()
        {
            Console.WriteLine("Enter the values of the array numbers on a single line, separated by space or comma: ");
            string input = Console.ReadLine();
            string[] someNumbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            float[] floating = new float[someNumbers.Length];

            for (int i = 0; i < someNumbers.Length; i++)
            {
                floating[i] = float.Parse(someNumbers[i]);
            }

            List<float> roundedFloats = new List<float>();
            List<float> nonRoundedFloats = new List<float>();

            foreach (float number in floating)
            {
                if (number % 1 == 0)
                {
                    nonRoundedFloats.Add(number);
                }
                else
                {
                    roundedFloats.Add(number);
                }
            }
            var minR = roundedFloats.Min();
            var maxR = roundedFloats.Max();
            var sumR = roundedFloats.Sum();
            var avgR = roundedFloats.Average();
            var min = nonRoundedFloats.Min();
            var max = nonRoundedFloats.Max();
            var sum = nonRoundedFloats.Sum();
            var avg = nonRoundedFloats.Average();

            PrintArrays(roundedFloats, minR, maxR, sumR, avgR);
            PrintArrays(nonRoundedFloats, min, max, sum, avg);
        }

        static void PrintArrays(List<float> listFloats, float min, float max, float sum, float avg)
        {
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(", ", listFloats), min, max, sum, avg);
        }
    }
}
