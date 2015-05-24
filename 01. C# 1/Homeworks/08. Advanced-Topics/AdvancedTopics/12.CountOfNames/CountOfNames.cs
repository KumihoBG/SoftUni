/* Write a program that reads a list of names and prints for each name how many times it appears in the list. The names should be listed in alphabetical order. */

namespace _12.CountOfNames
    {
    using System;
    using System.Collections.Generic;

    class CountOfNames
        {
        static void Main()
            {
            Console.WriteLine("Enter names: ");
            string input = Console.ReadLine();
            string[] text = input.Split(new[] { ' ', ',', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);

            var dictionary = new Dictionary<string, int>();

            //sorting the array
            Array.Sort(text);

            // searching and counting
            for (int i = 0; i < text.Length; i++)
                {
                int counter = 0;
                foreach (var word in text)
                    {
                    if (word == text[i])
                        {
                        counter++;
                        }
                    }
                if (!dictionary.ContainsKey(text[i]))
                    {
                    dictionary.Add(text[i], counter);
                    }
                }

            // printing the result
            foreach (var pair in dictionary)
                {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                }
            }
        }
    }
