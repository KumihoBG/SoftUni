using System;

namespace _15.TorrentPirate
    {
    class TorrentPirate
        {
        static void Main()
            {
            long downloadData = long.Parse(Console.ReadLine());
            double priceOfCinema = double.Parse(Console.ReadLine());
            byte wifeSpending = byte.Parse(Console.ReadLine());
            int movieSize = 1500;


            double hoursInTheMall = (double)downloadData / 2 / 60 / 60;
            double priceForDownload = hoursInTheMall * wifeSpending;
            double numberOfDownloadedMovies = (double)downloadData / movieSize;
            priceOfCinema = numberOfDownloadedMovies * priceOfCinema;

            if (priceOfCinema < priceForDownload)
                {
                Console.WriteLine("cinema -> {0:F2}lv", priceOfCinema);
                }
            else
                {
                Console.WriteLine("mall -> {0:F2}lv", priceForDownload);
                }
            }
        }
    }
