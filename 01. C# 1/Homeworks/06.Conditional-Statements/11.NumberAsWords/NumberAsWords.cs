// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation;

namespace NumberAsWords
    {
    using System;

    internal class NumberAsWords
        {
        private static void Main()
            {
            Console.WriteLine("Convert integer between [0...999] to words:");
            int number = int.Parse(Console.ReadLine());

            while (number < 0 || number > 999)
                {
                Console.WriteLine("Invalid input. Try again!");
                number = int.Parse(Console.ReadLine());
                }

            int hundreds = number / 100;
            int tens = (number / 10) % 10;
            int digits = number % 10;
            int special = 10 + digits;
            string others = "";
            string hundredsText = "";
            string tensText = "";
            string digitsText;

            switch (special)
                {
                case 11: others = "eleven"; break;
                case 12: others = "twelve"; break;
                case 13: others = "thirteen"; break;
                case 14: others = "fourteen"; break;
                case 15: others = "fifteen"; break;
                case 16: others = "sixteen"; break;
                case 17: others = "seventeen"; break;
                case 18: others = "eighteen"; break;
                case 19: others = "nineteen"; break;
                }

            switch (hundreds)
                {
                case 1: hundredsText = "one hundred "; break;
                case 2: hundredsText = "two hundred "; break;
                case 3: hundredsText = "three hundred "; break;
                case 4: hundredsText = "four hundred "; break;
                case 5: hundredsText = "five hundred "; break;
                case 6: hundredsText = "six hundred "; break;
                case 7: hundredsText = "seven hundred "; break;
                case 8: hundredsText = "eight hundred "; break;
                case 9: hundredsText = "nine hundred "; break;
                case 0: hundredsText = ""; break;
                }
            if (number % 100 != 0 && number >= 100)
                {
                hundredsText = hundredsText + "and ";
                }
            if (tens == 1 && digits > 0)
                {
                Console.WriteLine(hundredsText + others);
                hundredsText = tensText = "";
                }

            switch (tens)
                {
                case 1: tensText = "ten"; break;
                case 2: tensText = "twenty "; break;
                case 3: tensText = "thirty "; break;
                case 4: tensText = "fourty "; break;
                case 5: tensText = "fifty "; break;
                case 6: tensText = "sixty "; break;
                case 7: tensText = "seventy "; break;
                case 8: tensText = "eighty "; break;
                case 9: tensText = "ninety "; break;
                case 0: tensText = ""; break;
                }

            switch (digits)
                {
                case 1: digitsText = "one"; break;
                case 2: digitsText = "two"; break;
                case 3: digitsText = "three"; break;
                case 4: digitsText = "four"; break;
                case 5: digitsText = "five"; break;
                case 6: digitsText = "six"; break;
                case 7: digitsText = "seven"; break;
                case 8: digitsText = "eight"; break;
                case 9: digitsText = "nine"; break;
                default: digitsText = ""; break;
                }

            if (number == 0)
                {
                Console.WriteLine("Zero");
                hundredsText = tensText = digitsText = "";
                }
            if (number <= 10 || number >= 20)
                {
                Console.WriteLine(hundredsText + tensText + digitsText);
                }
            }
        }
    }
