using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text.RegularExpressions;
using System.Threading;

namespace _12.ChatLogger___regular_expression
    {
    class ChatLogger
        {
        static void Main()
            {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            var messages = new SortedDictionary<DateTime, string>();

            // input current time
            var currentTime = DateTime.Parse(Console.ReadLine());

            // input messages
            while (true)
                {
                string line = Console.ReadLine();

                if (line == "END")
                    {
                    break;
                    }
                const string pattern = @"(\s+\/+\s+)";
                var data = Regex.Split(line, pattern);

                messages.Add(DateTime.Parse(data[2]), data[0]);
                }

            DateTime mostRecentDate = messages.Last().Key;
            TimeSpan time = currentTime - mostRecentDate;

            // check for time span
            foreach (var pair in messages)
                {
                Console.WriteLine("<div>{0}</div>", SecurityElement.Escape(pair.Value));
                }
            if (mostRecentDate.Day < currentTime.Day - 1)
                {
                Console.WriteLine("<p>Last active: <time>{0}</time></p>", mostRecentDate.ToString("dd-MM-yyyy"));
                }

            else if (mostRecentDate.Day == currentTime.Day - 1)
                {
                Console.WriteLine("<p>Last active: <time>yesterday</time></p>");
                }
            else if (mostRecentDate.Day == currentTime.Day && time.TotalHours >= 1)
                {
                Console.WriteLine("<p>Last active: <time>{0} hour(s) ago</time></p>", (int)time.TotalHours);
                }
            else if (time.TotalHours < 1 && time.TotalMinutes >= 1)
                {
                Console.WriteLine("<p>Last active: <time>{0} minute(s) ago</time></p>", (int)time.TotalMinutes);
                }
            else
                {
                Console.WriteLine("<p>Last active: <time>a few moments ago</time></p>");
                }
            }
        }
    }