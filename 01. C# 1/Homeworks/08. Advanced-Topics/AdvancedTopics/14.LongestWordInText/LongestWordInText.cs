/* Write a program to find the longest word in a text. */

namespace _14.LongestWordInText
    {
    using System;
    using System.Linq;

    class LongestWordInText
        {
        static void Main()
            {
            Console.WriteLine("Enter some text: ");
            string input = Console.ReadLine();
            string[] text = input.Split(new[] { ' ', ',', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);

            var result = text.OrderBy(w => w.Length).Last();
            foreach (var word in result)
                {
                Console.Write(word);
                }
            Console.WriteLine();
            }
        }
    }
