using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _12.TheNumbers
    {
    class TheNumbers
        {
        static void Main()
            {
            /*var numbers = Regex.Split(Console.ReadLine(), @"[^0-9]+")
            .Where(x => x != string.Empty)
            .Select(number => string.Format("0x{0:X4}", int.Parse(number)));
 
            Console.WriteLine(string.Join("-", numbers));*/

            // input
            string message = Console.ReadLine();

            // regex
            const string numberPattern = @"([0-9]+)";
            Regex num = new Regex(numberPattern);
            MatchCollection matches = num.Matches(message);

            // string to numbers to hex
            List<string> hexNumbers =
                (from Match match in matches
                 select String.Format("0x{0}", int.Parse(match.Groups[1].Value).ToString("X").PadLeft(4, '0'))).ToList();

            // printing
            Console.WriteLine(string.Join("-", hexNumbers));
            }
        }
    }
