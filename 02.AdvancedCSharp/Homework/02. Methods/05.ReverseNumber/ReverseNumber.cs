/*Write a method that reverses the digits of a given floating-point number.*/

namespace _05.ReverseNumber
    {
    using System;
    using System.Globalization;
    using System.Linq;

    class ReverseNumber
        {
        static void Main()
            {
            Console.Write("Enter floating-point number: ");
            double input = double.Parse(Console.ReadLine());
            double reversed = GetReversedNumber(input);
            Console.WriteLine(reversed);
            }

        private static double GetReversedNumber(double input)
            {
            string result = string.Join("", input.ToString(CultureInfo.InvariantCulture).TrimStart('-').Reverse());
            double number = double.Parse(result);
            return number;
            }
        }
    }
