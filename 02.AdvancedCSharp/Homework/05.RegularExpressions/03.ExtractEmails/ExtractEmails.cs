/*Write a program to extract all email addresses from a given text. The text comes at the only input line. Print the emails on the console, each at a separate line.*/

namespace _03.ExtractEmails
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class ExtractEmails
    {
        static void Main()
        {
            // version using a regular expression
            string text = "Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. –- steve.parker@softuni.de."; //Console.ReadLine();
            string patternMeil = @"(?<=\s|^)[a-z0-9]+[_.-]?[a-z0-9]*@[a-z]+\-?[a-z]+(\.[a-z]+)+\b";
            Regex regexMail = new Regex(patternMeil);
            
            Console.WriteLine("The result from the regular expression search:");
            MatchCollection matches = regexMail.Matches(text);
            Console.WriteLine();
            foreach (Match name in matches)
            {
                Console.WriteLine(name.Groups[0]);
            }
            Console.WriteLine();

            // another version, without using a regular expression
            Console.WriteLine(new string('*', 23));
            Console.WriteLine("Much more inaccurate result, without using RE!");
            Console.WriteLine(String.Join(Environment.NewLine, ExtractEmail(text)));
        }

        private static List<string> ExtractEmail(string text)
        {
            var emails = new List<string>();
            string[] email = text.Split(new char[] { '"', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in email)
            {
                if (word.Contains("@"))
                {
                    emails.Add(word);
                }
            }
            return emails;
        }
    }
}

