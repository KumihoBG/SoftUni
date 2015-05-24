/* Write a program that extracts and prints all URLs from given text. URL can be in only two formats.*/

namespace _15.ExtractURLsFromText
    {
    using System;
    using System.Text.RegularExpressions;

    internal class ExtractURLsFromText
        {
        private static void Main()
            {
            // string text = Console.ReadLine();
            string text =
                "The site nakov.com can be access from http://nakov.com or www.nakov.com. It has subdomains like mail.nakov.com and svetlin.nakov.com. Please check http://blog.nakov.com for more information.";
            Regex linkParser = new Regex(@"(?:https?://|www.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            foreach (var item in linkParser.Matches(text))
                {
                Console.WriteLine(item);
                }
            Console.WriteLine();
            }
        }
    }
