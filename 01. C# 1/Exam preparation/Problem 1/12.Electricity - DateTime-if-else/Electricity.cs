using System;

namespace _12.Electricity
    {
    class Electricity
        {
        static void Main()
            {
            byte floors = byte.Parse(Console.ReadLine());
            byte flats = byte.Parse(Console.ReadLine());
            DateTime time = DateTime.Parse(Console.ReadLine());

            int sumOfWats;
            if (time.Hour >= 14 && time.Hour <= 18)
                {
                // Noon time
                double noonConsumption = (2 * 100.53) + (2 * 125.90);
                sumOfWats = (int)(noonConsumption * flats * floors);
                }
            else if (time.Hour >= 19 && time.Hour <= 23)
                {
                // Afternoon time
                double afternoonConsumption = (7 * 100.53) + (6 * 125.90);
                sumOfWats = (int)(afternoonConsumption * flats * floors);
                }
            else if (time.Hour >= 0 && time.Hour <= 8)
                {
                // Midnight time
                double midnightConsumption = (1 * 100.53) + (8 * 125.90);
                sumOfWats = (int)(midnightConsumption * flats * floors);
                }
            else
                {
                // Any other time --> zero consumption
                sumOfWats = 0;
                }

            Console.WriteLine(sumOfWats + " Watts");
            }
        }
    }
