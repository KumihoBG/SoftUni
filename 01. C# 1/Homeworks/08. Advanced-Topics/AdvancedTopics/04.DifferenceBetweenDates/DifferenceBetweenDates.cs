/*Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them.*/

namespace _04.DifferenceBetweenDates
    {
    using System;
    using System.Globalization;

    class DifferenceBetweenDates
        {
        static void Main()
            {
            Console.WriteLine("Enter start date in format \"dd.MM.yyyy\": ");
            string startingDate = Console.ReadLine();
            DateTime start = DateTime.ParseExact(startingDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter end date in format \"dd.MM.yyyy\": ");
            string endingDate = Console.ReadLine();
            DateTime end = DateTime.ParseExact(endingDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            // the distance between the days
            var result = start - end;

            // printing the result, using Math.Abs to format it
            Console.WriteLine("The distance between these two dates is: {0}", Math.Abs(result.Days));
            }
        }
    }