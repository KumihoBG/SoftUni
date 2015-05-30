using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _12.BiggestTableRow___regular_expression
    {
    class BiggestTableRow
        {
        static void Main()
            {
            // max sum storage and regex
            double maxSum = double.MinValue;
            List<string> storeValues = new List<string>();
            const string pattern = @"<td>([0-9\.-]+)<\/td>";
            Regex num = new Regex(pattern);

            // input
            string line = Console.ReadLine();
            line = Console.ReadLine();

            while (true)
                {
                if (line == "</table>")
                    {
                    break;
                    }
                line = Console.ReadLine();

                // check for max sum
                maxSum = CheckFor(num, line, maxSum, ref storeValues);
                }

            // print result
            if (storeValues.Count == 0)
                {
                Console.WriteLine("no data");
                }
            else
                {
                Console.WriteLine("{0} = {1}", maxSum, string.Join(" + ", storeValues));
                }
            }

        private static double CheckFor(Regex num, string line, double maxSum, ref List<string> storeValues)
            {
            double sum = 0;
            MatchCollection matches = num.Matches(line);
            List<string> storeValuesTemp = new List<string>();

            foreach (Match match in matches)
                {
                // calculate sum
                double number;
                string value = match.Groups[1].Value;
                bool isNumber = double.TryParse(value, out number);
                if (isNumber)
                    {
                    sum += number;
                    storeValuesTemp.Add(value);
                    }
                }

            // update max sum
            if (sum > maxSum && storeValuesTemp.Count > 0)
                {
                maxSum = sum;
                storeValues = storeValuesTemp;
                }
            return maxSum;
            }
        }
    }