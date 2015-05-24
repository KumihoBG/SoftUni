/*Write a program that reads a keyword and some text from the console and prints all sentences from the text, containing that word. A sentence is any sequence of words ending with '.', '!' or '?'. */

namespace _04.SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    class SentenceExtractor
    {
        static void Main()
        {
            string keyword = Console.ReadLine();
            string sentence = Console.ReadLine();

            string pattern = string.Format(@"(?<=\s|^)(.*?\b{0}\b.*?(?=\!|\.|\?)[?.!])", keyword);
            Regex regexSentence = new Regex(pattern);
            MatchCollection matches = regexSentence.Matches(sentence);
            
            foreach (Match item in matches)
            {
                Console.WriteLine(item.Groups[0]);
            }
        }
    }
}
