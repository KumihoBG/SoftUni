using System;
using System.Linq;
using System.Text;

namespace _03.MatrixShuffle
    {
    class MatrixShuffle
        {
        static void Main()
            {
            // input
            int size = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            // turn text into spiral
            var spiralMatrix = SpiralMatrix(size, text);

            // extract sentence
            var sentence = ComposeSentence(size, spiralMatrix);

            // palindrome check
            var isPalindrome = IsPalindrome(sentence);

            // print
            Console.WriteLine("<div style='background-color:{0}'>{1}</div>", isPalindrome ? "#4FE000" : "#E0000F", sentence);
            }

        private static bool IsPalindrome(string sentence)
            {
            string str = sentence.ToLower();
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
                {
                if (str[i] >= 97 && str[i] <= 122)
                    {
                    temp.Append(str[i]);
                    }
                }
            string one = string.Join("", temp);
            string two = string.Join("", one.Reverse());

            bool isPalindrome = one == two;
            return isPalindrome;
            }

        private static char[,] SpiralMatrix(int size, string text)
            {
            int totalCells = size * size;
            text = text.PadRight(totalCells, ' ');
            char[,] spiralMatrix = new char[size, size];

            int leftColumn = 0;
            int rightColumn = size - 1;
            int upperRow = 0;
            int bottomRow = size - 1;
            int count = 0;
            do
                {
                for (int i = leftColumn; i <= rightColumn; i++) // filling the upper row
                    {
                    spiralMatrix[upperRow, i] = text[count];
                    count++;
                    }
                upperRow++; // we go one row down

                for (int i = upperRow; i <= bottomRow; i++) // filling the right column
                    {
                    spiralMatrix[i, rightColumn] = text[count];
                    count++;
                    }
                rightColumn--; // we go to the next column

                for (int i = rightColumn; i >= leftColumn; i--) // filling bottom row
                    {
                    spiralMatrix[bottomRow, i] = text[count];
                    count++;
                    }
                bottomRow--; // one row up 

                for (int i = bottomRow; i >= upperRow; i--) // filling the leftmost column
                    {
                    spiralMatrix[i, leftColumn] = text[count];
                    count++;
                    }
                leftColumn++;
                ; // we go one column to the right
                } while (count < totalCells); // and continuing the spiral to the end of the text string
            return spiralMatrix;
            }

        private static string ComposeSentence(int size, char[,] spiralMatrix)
            {
            StringBuilder whiteText = new StringBuilder();
            StringBuilder blackText = new StringBuilder();
            for (int row = 0; row < size; row++)
                {
                for (int col = 0; col < size; col++)
                    {
                    if ((col % 2 == 0 && row % 2 == 0) || (col % 2 != 0 && row % 2 != 0))
                        {
                        whiteText.Append(spiralMatrix[row, col]);
                        }
                    else if ((col % 2 != 0 && row % 2 == 0) || (col % 2 == 0 && row % 2 != 0))
                        {
                        blackText.Append(spiralMatrix[row, col]);
                        }
                    }
                }

            string sentence = whiteText + blackText.ToString();
            return sentence;
            }
        }
    }