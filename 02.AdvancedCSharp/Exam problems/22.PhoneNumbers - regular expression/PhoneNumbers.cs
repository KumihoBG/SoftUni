using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _12.PhoneNumbers___regular_expression
    {
    class PhoneNumbers
        {
        static void Main()
            {
            // declarations
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            bool isMatch = false;

            // read input
            StringBuilder text = new StringBuilder();
            while (true)
                {
                string input = Console.ReadLine();
                if (input == "END")
                    {
                    break;
                    }
                text.Append(input);
                }

            // check for matches
            isMatch = NamePhoneCheck(text, phonebook, isMatch);

            // print result
            if (isMatch == false)
                {
                Console.WriteLine("<p>No matches!</p>");
                }
            else
                {
                PrintOrderedList(phonebook);
                }
            }

        private static void PrintOrderedList(Dictionary<string, string> phonebook)
            {
            Console.Write("<ol>");
            foreach (var pair in phonebook)
                {
                Console.Write("<li><b>{0}:</b> {1}</li>", pair.Key.Trim(), pair.Value.Trim());
                }
            Console.Write("</ol>");
            }

        private static bool NamePhoneCheck(StringBuilder text, Dictionary<string, string> phonebook, bool isMatch)
            {
            const string pattern = @"([A-Z][A-Za-z]*)[^0-9A-Za-z+]*([+]?[0-9]+[0-9\- \.\/\)\(]*[0-9]+)";
            Regex rgx = new Regex(pattern);
            MatchCollection matches = rgx.Matches(text.ToString());
            if (matches.Count > 0)
                {
                foreach (Match match in matches)
                    {
                    string name = match.Groups[1].Value;
                    string phone = match.Groups[2].Value;
                    string[] temp = phone.Split(new char[] { '(', ')', '/', '.', '-', ' ' },
                        StringSplitOptions.RemoveEmptyEntries);
                    phone = string.Join("", temp);
                    phonebook.Add(name, phone);
                    }
                isMatch = true;
                }
            return isMatch;
            }
        }
    }
