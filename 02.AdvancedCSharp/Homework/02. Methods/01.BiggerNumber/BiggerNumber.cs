/*Write a method GetMax() with two parameters that returns the larger of two integers. Write a program that reads 2 integers from the console and prints the largest of them using the method GetMax().*/

namespace _01.BiggerNumber
    {
    using System;

    internal class BiggerNumber
        {
        private static void Main()
            {
            Console.Write("Enter first number: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int numberTwo = int.Parse(Console.ReadLine());
            int max = GetMax(numberOne, numberTwo);
            Console.WriteLine("The bigger number among these two numbers is: {0}", max);
            }

        private static int GetMax(int numberOne, int numberTwo)
            {
            int max = Math.Max(numberOne, numberTwo);
            return max;
            //if (numberOne > numberTwo)
            //    {
            //    return numberOne;
            //    }
            //if (numberTwo > numberOne)
            //{
            //    return numberTwo;
            //}
            //return numberOne;
            //}
            }
        }
    }
