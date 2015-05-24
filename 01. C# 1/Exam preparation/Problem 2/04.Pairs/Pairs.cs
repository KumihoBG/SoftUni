/*You are given 2*N elements (even number of integer numbers). The first and the second element form a pair, the third and the fourth element form a pair as well, etc. Each pair has a value, calculated as the sum of its two elements. Your task is to write a program to check whether all pairs have the same value or print the max difference between two consecutive values.
 That's the author's solution*/

namespace _14.Pairs
    {
    using System;

    internal class Pairs
        {
        private static void Main()
            {
            // the input
            string inputLine = Console.ReadLine();
            string[] elements = inputLine.Split(' ');

            // having each two elements from the pair separated, as index 0 and 1
            int firstElement = int.Parse(elements[0]);
            int secondElement = int.Parse(elements[1]);

            // the sum of the two elements
            int prevValue = firstElement + secondElement;

            // the difference between the pairs
            int maxdiff = 0;

            // for loop over the array elements, updating with 2 each time
            for (int i = 2; i < elements.Length - 1; i += 2)
                {
                firstElement = int.Parse(elements[i]);
                secondElement = int.Parse(elements[i + 1]);
                int lastValue = firstElement + secondElement;
                int diff = Math.Abs(lastValue - prevValue);
                maxdiff = Math.Max(diff, maxdiff);
                prevValue = lastValue;
                }

            if (maxdiff == 0)
                {
                Console.WriteLine("Yes, value=" + prevValue);
                }
            else
                {
                Console.WriteLine("No, maxdiff=" + maxdiff);
                }
            }
        }
    }