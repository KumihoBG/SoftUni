// Using loops write a program that converts an integer number to its binary representation
// The input is entered as long. The output should be a variable of type string
// Do not use the built-in .NET functionality

using System;

namespace DecimalToBinaryNumber
{
    internal class DecimalToBinaryNumber
    {
        private static void Main()
        {
            Console.Write("Please, enter the decimal number: ");
            long input = long.Parse(Console.ReadLine());
            string binary = "";
            if (input == 0)
            {
                Console.WriteLine("The binary result is: 0");
            }
            else
            {
                while (input >= 1)
                {
                    binary = (input%2) + binary;
                    input = input/2;
                }
                Console.WriteLine("The binary result is: {0}", binary);
            }
        }
    }
}
