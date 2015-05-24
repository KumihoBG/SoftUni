/*Problem 6. Four-Digit Number

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
- Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
- Prints on the console the number in reversed order: dcba (in our example 1102).
- Puts the last digit in the first position: dabc (in our example 1201).
- Exchanges the second and the third digits: acbd (in our example 2101).
- The number has always exactly 4 digits and cannot start with 0.*/

using System;

class FourDigitNumber
    {
    static void Main()
        {
        Console.Write("Enter four-digit number: ");
        int number = int.Parse(Console.ReadLine());
        while (number > 9999 || number < 1000)
            {
            Console.WriteLine("The number must be exactly 4 digits and cannot start with 0. Please, try again!");
            number = int.Parse(Console.ReadLine());
            }

        int firstNumber = number / 1000;
        int secondNumber = (number / 100) % 10;
        int thirdNumber = (number / 10) % 10;
        int fourthNumber = number % 10;
        int sum = firstNumber + secondNumber + thirdNumber + fourthNumber;

        Console.WriteLine("Sum of digits: " + sum);
        Console.WriteLine("In reversed order: {0}{1}{2}{3}", fourthNumber, thirdNumber, secondNumber, firstNumber);
        Console.WriteLine("Last digit in the first position: {0}{1}{2}{3}", fourthNumber, firstNumber, secondNumber, thirdNumber);
        Console.WriteLine("Exchanged second and the third digits: {0}{1}{2}{3}", firstNumber, thirdNumber, secondNumber, fourthNumber);
        }
    }