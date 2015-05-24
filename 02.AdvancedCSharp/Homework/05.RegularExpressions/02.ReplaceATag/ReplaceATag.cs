/*Write a program that replaces in a HTML document given as string all the tags <a href=…>…</a> with corresponding tags [URL href=…]…[/URL]. Print the result on the console.
 Note: The input may be read on a single line (unlike the example above) or from a file. Remove all new lines if you choose the first approach.*/

namespace _02.ReplaceATag
{
    using System;
    using System.Text.RegularExpressions;

    class ReplaceATag
    {
        static void Main()
        {
            // version using a regular expression
            string inputRegex = "<ul><li><a href=http://softuni.bg>SoftUni</a></li></ul>";
            string pattern = @"<a.*?href=(.*?)>(.*?)<\/a>";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(inputRegex);
            foreach (Match symbol in matches)
            {
                string url = symbol.Groups[1].ToString();
                string text = symbol.Groups[2].ToString();
                regex.Replace(inputRegex, symbol.ToString());
                string replace = @"[URL href=" + url + "]" + text + "[/URL]";
                Console.WriteLine(Regex.Replace(inputRegex, pattern, replace));
            }

            // Another version, without using regular expression
            string input = "<ul><li><a href=http://softuni.bg>SoftUni</a></li></ul>";
            input = input.Replace("<a href=", "[URL href=");
            input = input.Replace("</a>", "[/URL]");
            input = input.Replace("\">", "]");
            Console.WriteLine(input);
        }
    }
}
