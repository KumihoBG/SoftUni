/*Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.*/

namespace _01.SeriesOfLetters
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class SeriesOfLetters
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"([\w])\1+";
            MatchCollection matches = Regex.Matches(text, pattern);
            for (int i = 0; i < matches.Count; i++)
            {
                string temp = matches[i].ToString();
                string replace = temp.First().ToString();
                Regex reg = new Regex(temp);
                text = reg.Replace(text, replace);
            }
            Console.WriteLine(text);
        }
    }
}

