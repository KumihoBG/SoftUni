/*Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns*/

namespace _07.MatrixOfPalindromes
    {
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class MatrixOfPalindromes
        {
        private static void Main()
            {
            Console.Write("Enter value for r: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Enter value for c: ");
            int c = int.Parse(Console.ReadLine());

            List<string> palindromes = MakePalindromes();

            string[,] matrix = new string[r, c];
            int index = 0;
            for (int row = 0; row < r; row++)
                {
                for (int col = 0; col < c; col++)
                    {
                    matrix[row, col] = palindromes[index];
                    index++;
                    }
                index += 27 - c; 
                }

            PrintMatrix(r, c, matrix);
            }

        private static void PrintMatrix(int r, int c, string[,] matrix)
            {
            Console.WriteLine();
            for (int row = 0; row < r; row++)
                {
                for (int col = 0; col < c; col++)
                    {
                    Console.Write("{0} ", matrix[row, col]);
                    }
                Console.WriteLine();
                }
            Console.WriteLine();
            }

        private static List<string> MakePalindromes()
            {
            char[] letters =
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'g', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };
            List<string> palindromes = new List<string>();

            foreach (char c1 in letters)
                {
                foreach (char c2 in letters)
                    {
                    palindromes.AddRange(letters.Select(t => "" + c1 + c2 + t).Where(PalindromeCheck));
                    }
                }
            return palindromes;
            }

        private static bool PalindromeCheck(string s)
            {
            bool isPalindrome = s == String.Join("", s.Reverse());
            return isPalindrome;
            }
        }
    }
