using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _12.OhMyGirl___regular_expression
    {
    class OhMyGirl
        {
        static void Main()
            {
            char[] specialSymbols = { '*', '+', '?', '[', ']', '{', '}', ',', '.', '^', '$', '<', '>', '\\', '/' };
            // input key
            string key = Console.ReadLine();

            // input text
            var text = GetText();

            // extract key pattern
            var pattern = ExtractKeyPattern(key, specialSymbols);
            //Console.WriteLine(pattern);

            // extract address
            var address = ExtractAddress(pattern, text);

            // print
            Console.WriteLine(address);
            }

        private static StringBuilder ExtractAddress(string pattern, string text)
            {
            Regex addressPiece = new Regex(pattern);
            MatchCollection matches = addressPiece.Matches(text);

            StringBuilder address = new StringBuilder();

            foreach (Match match in matches)
                {
                address.Append(match.Groups[1].Value);
                }
            return address;
            }

        private static string ExtractKeyPattern(string key, char[] specialSymbols)
            {
            StringBuilder keyPattern = new StringBuilder();
            if (char.IsControl(key[0]) || specialSymbols.Contains(key[0]))
                {
                keyPattern.Append(String.Format("\\" + key[0]));
                }
            else
                {
                keyPattern.Append(key[0]);
                }

            for (int i = 1; i < key.Length - 1; i++)
                {
                char symbol = key[i];
                if (char.IsUpper(symbol))
                    {
                    keyPattern.Append("[A-Z]*");
                    }
                else if (char.IsLower(symbol))
                    {
                    keyPattern.Append("[a-z]*");
                    }
                else if (char.IsDigit(symbol))
                    {
                    keyPattern.Append("\\d*");
                    }
                else if (!char.IsControl(symbol))
                    {
                    keyPattern.Append(String.Format("\\" + symbol));
                    }
                else
                    {
                    keyPattern.Append(symbol);
                    }
                }
            if (char.IsControl(key[key.Length - 1]) || specialSymbols.Contains(key[key.Length - 1]))
                {
                keyPattern.Append(String.Format("\\" + key[key.Length - 1]));
                }
            else
                {
                keyPattern.Append(key[key.Length - 1]);
                }

            string keyPatternStr = keyPattern.ToString();
            string pattern = String.Format(keyPatternStr + "(.{{2,6}})" + keyPatternStr);
            return pattern;
            }

        private static string GetText()
            {
            StringBuilder text = new StringBuilder();
            while (true)
                {
                string line = Console.ReadLine();
                if (line == "END")
                    {
                    break;
                    }

                text.Append(line);
                }
            return text.ToString();
            }
        }
    }
