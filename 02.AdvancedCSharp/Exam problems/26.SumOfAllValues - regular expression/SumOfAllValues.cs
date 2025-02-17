﻿using System;
using System.Text.RegularExpressions;

namespace _12.SumOfAllValues
    {
    class SumOfAllValues
        {
        static void Main()
            {
            // input
            string keys = Console.ReadLine();
            string text = Console.ReadLine();

            // extracting start and end keys from the keys string
            string endKey;
            var startKey = ExtractKeys(keys, out endKey);

            // if one or more keys are missing
            if (startKey == String.Empty || endKey == String.Empty)
                {
                Console.WriteLine("<p>A key is missing</p>");
                }
            else
                {
                // extracting numbers
                string numbersPattern = String.Format("{0}(.*?){1}", startKey, endKey);
                MatchCollection matches = Regex.Matches(text, numbersPattern);

                // calculating sum
                double sum = 0;
                    foreach (Match match in matches)
                    {
                        double number;
                        var numeric = double.TryParse(match.Groups[1].Value, out number);
                    if (numeric)
                        {
                        sum += number;
                        }
                    }

                // printing
                if (sum == 0)
                    {
                    Console.WriteLine("<p>The total value is: <em>nothing</em></p>");
                    }
                else
                    {

                    Console.WriteLine("<p>The total value is: <em>{0}</em></p>", sum);
                    }
                }
            }
        private static string ExtractKeys(string keys, out string endKey)
            {
            const string startKeyPattern = @"^([a-zA-Z_]+)\d+";
            const string endKeyPattern = @"\d+([a-zA-Z_]+)$";
            string startKey = Regex.Match(keys, startKeyPattern, RegexOptions.None).Groups[1].Value;
            endKey = Regex.Match(keys, endKeyPattern, RegexOptions.None).Groups[1].Value;
            return startKey;
            }
        }
    }
