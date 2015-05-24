/*Write a program that takes a text and a string of banned words. All words included in the ban list should be replaced with asterisks "*", equal to the word's length. The entries in the ban list will be separated by a comma and space ", ".
The ban list should be entered on the first input line and the text on the second input line.*/

namespace _04.TextFilter
{
    using System;
    using System.Linq;

    class TextFilter
    {
        static void Main()
        {
            string[] banList = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            Console.WriteLine();
            text = banList.Aggregate(text, (current, word) => current.Replace(word, new string('*', word.Length)));

            Console.WriteLine(text);
        }
    }
}
