/*Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe and prints them on the console on a single line, separated by comma and space. Use spaces, commas, dots, question marks and exclamation marks as word delimiters. Print only unique palindromes, sorted lexicographically.*/

namespace _06.Palindromes
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Palindromes
    {
        static void Main()
        {
            string words = Console.ReadLine();
            var result = Regex.Matches(words, @"\w+").Cast<Match>()
                        .Select(m => m.Value)
                        .Where(w => String.Join("", w.Reverse()) == w).ToList();
            Console.WriteLine(string.Join(", ", result.OrderBy(r => r)));
        }
    }
}
