/*Write a program that reads some text from the console and counts the occurrences of each character in it. Print the results in alphabetical (lexicographical) order. */

namespace _06.CountSymbols
{
    using System;
    using System.Linq;

    class CountSymbols
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var result = input.GroupBy(x => x).OrderBy(x => x.First());

            foreach (var item in result)
            {
                Console.WriteLine("{0}: {1} time/s", item.First(), item.Count());
            }
        }
    }
}
