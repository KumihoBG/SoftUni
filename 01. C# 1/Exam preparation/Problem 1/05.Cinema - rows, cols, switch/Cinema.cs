namespace _05.Cinema___rows__cols__switch
    {
    using System;

    class Cinema
        {
        static void Main()
            {
            string typeOfProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            decimal price = 0;
            int totalPeopleWatching = rows * cols;
            switch (typeOfProjection)
                {
                case "Premiere":
                    price = 12.00m * totalPeopleWatching;
                    break;
                case "Normal":
                    price = 7.50m * totalPeopleWatching;
                    break;
                case "Discount":
                    price = 5.00m * totalPeopleWatching;
                    break;
                }
            Console.WriteLine("{0:F2} leva", price);
            }
        }
    }
