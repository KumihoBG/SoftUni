/*Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *. Print the resulting string on the console.*/

namespace _02.StringLenght
{
    using System;

    class StringLenght
    {
        static void Main()
        {
            Console.WriteLine("Enter some text (the max lenght is 20 characters: ");
            string someText = Console.ReadLine();
            char pad = '*';

            int actualLenght = someText.Length;
            if (actualLenght < 20)
            {
                var result = someText.PadRight(20, pad);
                Console.WriteLine(result);
            }
            else
            {
                var result = someText.Remove(20);
                Console.WriteLine(result);
            }
        }
    }
}
