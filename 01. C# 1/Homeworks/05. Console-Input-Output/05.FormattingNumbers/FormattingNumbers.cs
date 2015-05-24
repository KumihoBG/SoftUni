/* Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned. */

namespace FormattingNumbers
{
    using System;
    using System.Threading;
    using System.Globalization;

    class FormattingNumbers
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please, enter an integer number (0 <= a <= 500): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Now, enter the first floating-point number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the second floating-point number: ");
            double c = double.Parse(Console.ReadLine());
            if (0 <= a && a <= 500)
            {
                Console.WriteLine("{0,-10:X}" + "|" + "{1}" + "|" + "{2,10:N2}" + "|" + "{3,-10:F3}" + "|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c); 
            }
            else
            {
                Console.WriteLine("This number is not correct!");
            }      
        }
    }
}
