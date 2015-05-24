/* Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. */

using System;
using System.Threading;
using System.Globalization;

namespace SumOfFiveNumbers
    {
    class SumOfFiveNumbers
        {
        static void Main()
            {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please, enter five numbers in a single line, separated by a space: ");

            string fiveNumbers = Console.ReadLine();
            string[] arrStr = fiveNumbers.Split(' '); // splitting by spacebar
            double[] nums = new double[arrStr.Length]; // making an array with the lenght of the string array
            for (int i = 0; i < arrStr.Length; i++)   // using a loop to get fill the array
                {
                nums[i] = double.Parse(arrStr[i]);
                }
            double sum = 0;

            foreach (var result in arrStr)
                {
                sum += double.Parse(result); // using foreach to sumarize the numbers 
                }
            Console.WriteLine("The sum of these five numbers is: {0}", sum);
            }
        }
    }
