using System;
using System.Text;

class ProgrammerDNA14Apr20142
    {
    static void Main()
        {
        int N = int.Parse(Console.ReadLine());
        string letter = Console.ReadLine().ToUpper();

        string[] letters = { "A", "B", "C", "D", "E", "F", "G" };
        StringBuilder text = new StringBuilder();
        int L = letters.Length;
        int index = Array.IndexOf(letters, letter);
        int codeLength = 0;

        string dots;
        string code = "";
        do
            {
            if (codeLength < 7)
                {
                for (int i = 0; i < 4; i++)
                    {
                    if (N == 0)
                        {
                        return;
                        }
                    dots = new string('.', 3 - i);
                    codeLength = (1 + 2 * i);

                    for (int j = index; j < index + codeLength; j++)
                        {
                        text.Append(letters[j % 7]);
                        }
                    code = text.ToString();

                    Console.WriteLine("{0}{1}{0}", dots, code);
                    text.Clear();
                    index = (index + codeLength) % 7;
                    N--;
                    }
                }
            if (codeLength >= 7)
                {
                for (int k = 2; k >= 0; k--)
                    {
                    if (N == 0)
                        {
                        return;
                        }
                    dots = new string('.', 3 - k);
                    codeLength = (1 + 2 * k);
                    for (int l = index; l < index + codeLength; l++)
                        {
                        text.Append(letters[l % 7]);
                        }
                    code = text.ToString();
                    Console.WriteLine("{0}{1}{0}", dots, code);
                    text.Clear();
                    index = (index + codeLength) % 7;
                    N--;
                    }
                }
            } while (N > 0);
        }
    }