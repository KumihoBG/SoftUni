/*Problem 1. Odd or Even Integers
Write an expression that checks if given integer is odd or even.
Examples:
n	Odd?
3	true
2	false
-2	false
-1	true
0	false*/

using System;

class OddOrEven
    {
    static void Main()
        {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        bool Odd = ((number % 2) != 0); // checking if the number is not divisable to 2 with remainder 0
        Console.WriteLine("Odd? " + Odd);
        }
    }

