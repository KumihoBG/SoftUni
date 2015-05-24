// Using loops write a program that converts a binary integer number to its decimal form
// The input is entered as string. The output should be a variable of type long
// Do not use the built-in .NET functionality

using System;

namespace BinaryToDecimalNumber
    {
    class BinaryToDecimalNumbers
        {
        static void Main()
            {
            Console.Write("Please, enter the binary number: ");
            string input = Console.ReadLine();
            long result = 0;
            for (int i = 0; i < input.Length; i++)
                {
                if (input[input.Length - i - 1] == '0')
                    {
                    continue;
                    }
                result += (long)Math.Pow(2, i);
                }
            Console.WriteLine("The decimal number of {0} is: {1}", input, result);
            }
        }
    }
