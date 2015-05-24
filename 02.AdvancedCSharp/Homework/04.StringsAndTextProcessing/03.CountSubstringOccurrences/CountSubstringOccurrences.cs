/*Write a program to find how many times a given string appears in a given text as substring. The text is given at the first input line. The search string is given at the second input line. The output is an integer number. Please ignore the character casing. Overlapping between occurrences is allowed.*/

namespace _03.CountSubstringOccurrences
{
    using System;
    using System.Linq;

    class CountSubstringOccurrences
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string word = Console.ReadLine();

            int count = text.Select((c, i) => text.Substring(i)).Count(x => x.StartsWith(word, StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine(count);
        }
    }
}
