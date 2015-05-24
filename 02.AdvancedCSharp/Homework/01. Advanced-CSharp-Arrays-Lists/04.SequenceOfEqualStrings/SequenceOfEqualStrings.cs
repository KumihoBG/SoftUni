/*Write a program that reads an array of strings and finds in it all sequences of equal elements (comparison should be case-sensitive). The input strings are given as a single line, separated by a space.*/

namespace _04.SequenceOfEqualStrings
{
    using System;
    using System.Linq;

    class SequenceOfEqualStrings
    {
        static void Main()
        {
            Console.WriteLine("Enter the words on a single line, separated by space or comma: ");
            string[] input = Console.ReadLine().Split(' ');
            var result = input.GroupBy(name => name);
            foreach (var word in result)
            {
                Console.WriteLine(string.Join(" ", word));
            }
            Console.WriteLine();
        }
    }
}
