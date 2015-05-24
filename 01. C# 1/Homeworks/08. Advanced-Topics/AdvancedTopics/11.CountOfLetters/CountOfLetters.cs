/*Write a program that reads a list of letters and prints for each letter how many times it appears in the list. The letters should be listed in alphabetical order. */

namespace _11.CountOfLetters
    {
    using System;
    using System.Collections.Generic;

    class CountOfLetters
        {
        static void Main()
            {
            Console.WriteLine("Enter some letters separated by space or comma: ");
            string text = Console.ReadLine();

            var result = new Dictionary<char, int>();

            foreach (char letter in text)
            {
                if (!result.ContainsKey(letter) && char.IsLetter(letter))
                {
                    result.Add(letter, 1);
                }
                else if (result.ContainsKey(letter) && char.IsLetter(letter))
                {
                    result[letter] += 1;
                }
            }
            Console.WriteLine();


            foreach (var letter in result)
                {
                Console.WriteLine("{0} -> {1}", letter.Key, letter.Value);
                }
            }
        }
    }