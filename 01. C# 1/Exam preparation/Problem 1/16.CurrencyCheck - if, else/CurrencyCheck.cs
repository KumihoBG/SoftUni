using System;

namespace _16.CurrencyCheck
    {
    class CurrencyCheck
        {
        static void Main()
            {
            long rubles = long.Parse(Console.ReadLine());
            long dollars = long.Parse(Console.ReadLine());
            long euro = long.Parse(Console.ReadLine());
            long levaB = long.Parse(Console.ReadLine());
            long levaM = long.Parse(Console.ReadLine());


            decimal gamePriceInRubles = (decimal)rubles / 100;
            decimal resultInRubles =  (gamePriceInRubles * (decimal) 3.5);
            decimal gamePriceInDollars = (decimal) (dollars * 1.5);
            decimal gamePriceInEuros = (decimal) (euro * 1.95);
            decimal pricePerTwoGames = (decimal)levaB / 2;
            decimal priceInLevaM = levaM;
            if (resultInRubles < gamePriceInDollars && resultInRubles < gamePriceInEuros && resultInRubles < pricePerTwoGames && resultInRubles < priceInLevaM)
                {
                Console.WriteLine("{0:F2}", resultInRubles);
                }
            else if (gamePriceInDollars < resultInRubles && gamePriceInDollars < gamePriceInEuros && gamePriceInDollars < pricePerTwoGames && gamePriceInDollars < priceInLevaM)
                {
                Console.WriteLine("{0:F2}", gamePriceInDollars);
                }
            else if (gamePriceInEuros < resultInRubles && gamePriceInEuros < gamePriceInDollars && gamePriceInEuros < pricePerTwoGames && gamePriceInEuros < priceInLevaM)
                {
                Console.WriteLine("{0:F2}", gamePriceInEuros);
                }
            else if (pricePerTwoGames < resultInRubles && pricePerTwoGames < gamePriceInDollars && pricePerTwoGames < gamePriceInEuros && pricePerTwoGames < priceInLevaM)
                {
                Console.WriteLine("{0:F2}", pricePerTwoGames);
                }
            else
                {
                Console.WriteLine("{0:F2}", priceInLevaM);
                }
            }
        }
    }
