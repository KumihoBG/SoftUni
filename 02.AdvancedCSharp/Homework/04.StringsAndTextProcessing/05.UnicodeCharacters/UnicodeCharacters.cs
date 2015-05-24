/*Write a program that converts a string to a sequence of C# Unicode character literals.*/

namespace _05.UnicodeCharacters
{
    using System;

    class UnicodeCharacters
    {
        static void Main()
        {
            Console.WriteLine("Enter some string: ");
            string text = Console.ReadLine();
            char[] arrayOfChars = text.ToCharArray();
            for (int i = 0; i < arrayOfChars.Length; i++)
            {
                Console.Write("\\{0:X4}", ((int)arrayOfChars[i]));
            }
            Console.WriteLine();
        }
    }
}
