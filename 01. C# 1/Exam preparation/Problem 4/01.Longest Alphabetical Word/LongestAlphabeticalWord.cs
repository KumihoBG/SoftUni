using System;
using System.Collections.Generic;

namespace _01.Longest_Alphabetical_Word
    {
    internal class LongestAlphabeticalWord
        {
        private static void Main()
            {
            string word = Console.ReadLine().ToLower();
            byte n = byte.Parse(Console.ReadLine());

            // Find the longest alphabetical word in the matrix of letters
            string longestAlphaWord = "";
            for (int row = 0; row < n; row++)
                {
                for (int col = 0; col < n; col++)
                    {
                    string strLeft = FindAlphabeticalWord(word, n, row, col, -1, 0);
                    longestAlphaWord = GetBetterWord(longestAlphaWord, strLeft);
                    string strRight = FindAlphabeticalWord(word, n, row, col, +1, 0);
                    longestAlphaWord = GetBetterWord(longestAlphaWord, strRight);
                    string strUp = FindAlphabeticalWord(word, n, row, col, 0, -1);
                    longestAlphaWord = GetBetterWord(longestAlphaWord, strUp);
                    string strDown = FindAlphabeticalWord(word, n, row, col, 0, +1);
                    longestAlphaWord = GetBetterWord(longestAlphaWord, strDown);
                    }
                }

            Console.WriteLine(longestAlphaWord);
            }

        private static string FindAlphabeticalWord(
            string word, int n, int row, int col, int directionX, int directionY)
            {
            List<char> letters = new List<char>();
            char previousLetter = GetLetterAtPosition(word, n, row, col);
            letters.Add(previousLetter);
            while (true)
                {
                col = col + directionX;
                row = row + directionY;
                if (row < 0 || row >= n || col < 0 || col >= n)
                    {
                    // We are of range --> stop appending letters
                    break;
                    }
                char nextLetter = GetLetterAtPosition(word, n, row, col);
                if (nextLetter <= previousLetter)
                    {
                    // Non alphabetical order --> stop appending letters
                    break;
                    }
                letters.Add(nextLetter);
                previousLetter = nextLetter;
                }

            string alphaWord = new string(letters.ToArray());
            return alphaWord;
            }

        private static char GetLetterAtPosition(string word, int n, int row, int col)
            {
            char ch = word[(row * n + col) % word.Length];
            return ch;
            }

        private static string GetBetterWord(string firstWord, string secondWord)
            {
            if ((firstWord.Length > secondWord.Length) ||
                ((firstWord.Length == secondWord.Length &&
                 String.Compare(firstWord, secondWord, StringComparison.Ordinal) < 0)))
                {
                return firstWord;
                }

            return secondWord;
            }
        }
    }