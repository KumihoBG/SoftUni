using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.UseYourChainsBuddy___regular_expression
    {
    class UseYourChainsBuddy
        {
        static void Main()
            {
            // input
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            string html = Console.ReadLine();

            // regex patterns
            string pattern = @"<p>(.[^\/]+)<\/p>";
            string regex = @"[^a-z0-9]+";

            // logic - collecting the alpanumeric characters
            Regex words = new Regex(pattern);
            MatchCollection matches = words.Matches(html);
            string encrypted = "";
            for (int i = 0; i < matches.Count; i++)
                {
                string temp = matches[i].Groups[1].Value;
                encrypted += Regex.Replace(temp, regex, word => " ");
                }

            // decrypting
            string manual = "";
            for (int i = 0; i < encrypted.Length; i++)
                {
                if (encrypted[i] >= 'a' && encrypted[i] <= 'm')
                    {
                    manual += (char)(encrypted[i] + 13);
                    //Console.WriteLine(manual);
                    }
                else if (encrypted[i] >= 'n' && encrypted[i] <= 'z')
                    {
                    manual += (char)(encrypted[i] - 13);
                    }
                else if (Char.IsDigit(encrypted[i]) || Char.IsWhiteSpace(encrypted[i]))
                    {
                    manual += encrypted[i];
                    }
                }
            Console.WriteLine(manual);
            }
        }
    }
