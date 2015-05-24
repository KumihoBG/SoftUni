/* Write a program that takes as input two lists of names and removes from the first list all names given in the second list. The input and output lists are given as words, separated by a space, each list at a separate line. */

namespace _09.RemoveNames
    {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RemoveNames
        {
        static void Main()
            {
            Console.WriteLine("Please, enter first list of names: ");
            List<string> firstListOfNames = Console.ReadLine().Split(' ').ToList();
            Console.WriteLine("Please, enter second list of names: ");
            List<string> secondListOfNames = Console.ReadLine().Split(' ').ToList();

            foreach (string name in secondListOfNames)
                {
                if (firstListOfNames.Contains(name))
                    {
                    firstListOfNames.RemoveAll(item => item == name);
                    }
                }

            Console.WriteLine();
            Console.WriteLine("The list with removed names: ");
            Console.WriteLine(string.Join(" ", firstListOfNames));
            }
        }
    }
