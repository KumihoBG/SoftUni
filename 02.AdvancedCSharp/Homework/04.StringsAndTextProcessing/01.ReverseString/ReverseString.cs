/*Write a program that reads a string from the console, reverses it and prints the result back at the console.*/

namespace _01.ReverseString
{
    using System;

    class ReverseString
    {
        static void Main()
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();
            char[] arrayOfSymbols = input.ToCharArray();
            Array.Reverse(arrayOfSymbols);
            Console.WriteLine(string.Join("", arrayOfSymbols));
        }
    }
}
