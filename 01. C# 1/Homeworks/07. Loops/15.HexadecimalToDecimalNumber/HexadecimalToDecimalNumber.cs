// Using loops write a program that converts a hexadecimal integer number to its decimal form
// The input is entered as string. The output should be a variable of type long
// Do not use the built-in .NET functionality

using System;

namespace HexadecimalToDecimalNumber
    {
    class HexadecimalToDecimalNumber
        {
        static void Main()
            {
            Console.Write("Enter hexadecimal number: ");
            string hexaNumber = Console.ReadLine();

            long decNumber = 0;
            int result = hexaNumber.Length - 1;

            for (int i = 0; i < hexaNumber.Length; i++, result--)
                {
                int num;
                switch (hexaNumber[i])
                    {
                    case 'A': num = 10;
                        break;
                    case 'B': num = 11;
                        break;
                    case 'C': num = 12;
                        break;
                    case 'D': num = 13;
                        break;
                    case 'E': num = 14;
                        break;
                    case 'F': num = 15;
                        break;
                    default: num = int.Parse(hexaNumber[i].ToString());
                        break;
                    }
                long sum = 1;
                for (int j = 0; j < result; j++)
                    {
                    sum *= 16;
                    }
                sum *= num;
                decNumber += sum;
                }
            Console.WriteLine("The decimal number is: {0}",
                decNumber);
            }
        }
    }
