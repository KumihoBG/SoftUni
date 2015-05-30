/*Write a program to sort an array of integer numbers and then print them back on the console. The numbers should be entered from the console on a single line, separated by a space.*/

namespace _06.BubbleSort
    {
    using System;
    using System.Linq;

    class BubbleSort
        {
        static void Main()
            {
            int[] masiv = Console.ReadLine() // прочети ми го от конзолата
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                // раздели ми го и премахни празнотите
                .Select(int.Parse) // за всеки стринг, който си получил, парсни го
                .ToArray(); // и го направи на масив

            while (true)
                {
                bool hasSwapped = false;
                for (int i = 0; i < masiv.Length - 1; i++)
                    {
                    if (masiv[i] > masiv[i + 1])
                        {
                        int oldValue = masiv[i]; // нова променлива да пази резултата
                        masiv[i] = masiv[i + 1];
                        masiv[i + 1] = oldValue;
                        hasSwapped = true;
                        }
                    }
                if (!hasSwapped)
                    {
                    break;
                    }
                }

            foreach (var number in masiv)
                {
                Console.Write(number + " ");
                }
            Console.WriteLine();
            }
        }
    }