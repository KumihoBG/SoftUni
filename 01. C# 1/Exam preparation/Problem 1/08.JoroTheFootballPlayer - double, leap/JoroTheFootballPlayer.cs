/* Check the detailed description of the requirements in the homework documentation*/

namespace _15.JoroTheFootballPlayer
    {
    using System;

    class JoroTheFootballPlayer
        {
        static void Main()
            {
            string leapYear = Console.ReadLine();
            int hollidaysCount = int.Parse(Console.ReadLine());
            int numberOfWeekends = int.Parse(Console.ReadLine());
            int totalWeekendsInYear = 52;
            int normalWeekends = totalWeekendsInYear - numberOfWeekends;

            double result = normalWeekends * 2d / 3d + numberOfWeekends * 1d + hollidaysCount / 2d;

            if (leapYear == "t")
                {
                result = result + 3;
                }
            Console.WriteLine((int)result);
            }
        }
    }
