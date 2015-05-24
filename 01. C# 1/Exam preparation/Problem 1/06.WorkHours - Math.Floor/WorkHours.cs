namespace _13.WorkHours
    {
    using System;

    class WorkHours
        {
        static void Main()
            {
            int requiredHours = int.Parse(Console.ReadLine());
            int availableDays = int.Parse(Console.ReadLine());
            int perCent = int.Parse(Console.ReadLine());
            double daysDiff = availableDays * 0.1;
            double days = availableDays - daysDiff;
            const int normalWorkDay = 12;
            double workHours = days * normalWorkDay;
            double efficientWorkingHours = Math.Floor(workHours * perCent / 100);
            double difference = efficientWorkingHours - requiredHours;
            if (efficientWorkingHours > requiredHours || efficientWorkingHours == requiredHours)
                {
                Console.WriteLine("Yes");
                Console.WriteLine((int)difference);
                }
            else
                {
                Console.WriteLine("No");
                Console.WriteLine((int)difference);
                }
            }
        }
    }
