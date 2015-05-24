/* Problem 17.	**– Volleyball
This problem is from Variant 2 of C# Basics exam from 10-04-2014 Evening.  You can test your solution here .
Vladi loves a lot to play volleyball. However, he is a programmer now and he is very busy. Now he 
 * is able to play only in the holidays and in the weekends. Vladi plays in 2/3 of the holidays and each Saturday, 
 * but not every weekend – only when he is not at work and only when he is not going to his hometown. 
 * Vladi goes at his hometown h weekends in the year. The other weekends are considered “normal”. 
 * Vladi is not at work in 3/4 of the normal weekends. When Vladi is at his hometown, he always plays 
 * volleyball with his old friends once, at Sunday. In addition, if the year is leap, 
 * Vladi plays volleyball 15% more times additionally. We assume the year has exactly 48 weekends suitable for volleyball.
Your task is to write a program that calculates how many times Vladi plays volleyball (rounded down to the nearest integer number).
Input
The input data should be read from the console. It consists of three input values, each at separate line:
•	The string “leap” for leap year or “normal” for year that is not leap.
•	The number p – number of holidays in the year (which are not Saturday or Sunday).
•	The number h – number of weekends that Vladi spends in his hometown.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
•	The output data must be printed on the console.
•	On the only output line you must print an integer representing how many times Vladi plays volleyball for a year.
 */

namespace _17.Volleyball
    {
    using System;

    class Volleyball
        {
        static void Main()
            {
            string leap = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());
            const int weekendsTotal = 48;
            int normalWeekends = weekendsTotal - weekends;
            double resultWeekends = normalWeekends * (3.0 / 4.0);
            double resultHolidays = holidays * (2.0 / 3.0);
            double finalResult = resultWeekends + resultHolidays + weekends * 1.0;
            if (leap == "leap")
                {
                double leapResult = finalResult * ((double)15 / 100);
                double result = leapResult + finalResult;
                Console.WriteLine((int)result);
                }
            else
                {
                Console.WriteLine((int)finalResult);
                }
            }
        }
    }
