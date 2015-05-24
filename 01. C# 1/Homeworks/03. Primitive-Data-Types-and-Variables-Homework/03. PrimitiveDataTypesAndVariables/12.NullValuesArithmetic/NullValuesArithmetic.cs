/* Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.*/

namespace _12.NullValuesArithmetic
    {
    using System;

    class NullValuesArithmetic
        {
        static void Main()
            {
            int? a = null;
            double? b = null;
            Console.WriteLine("The null value of an integer number: " + a);
            Console.WriteLine("The null value of a double number: " + b);
            a = 10;
            b = 10.4;
            Console.WriteLine("The new value of the integer variable is now: " + a);
            Console.WriteLine("The new value of the double variable is now: " + b);
            }
        }
    }
