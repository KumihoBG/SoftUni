using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.NumeralSystems
{
    internal class NumeralSystems
    {
        private static void Main()
        {
            // Конвертиране на бройни системи - мързелив начин: 
            // да се сменя fromBase и toBase, както и имената на променливите за яснота
            Console.Write("Enter a decimal number to convert: ");
            string decimalNumber1 = Console.ReadLine();
            int fromBase = 10;
            int toBase = 2;

            var result = Convert.ToString((long) Convert.ToUInt64(decimalNumber1, fromBase), toBase);
            Console.WriteLine("The number {0} converted into binary is: {1}", decimalNumber1, result);

            // КОНВЕРТИРАНЕ В ДЕСЕТИЧНА СИСТЕМА,ДРУГ МЕТОД
            string[] alpha = { "f", "bIN", "oBJEC", "mNTRAVL", "lPVKNQ", "pNWE", "hT" };
            var input = Console.ReadLine();
            var currLetter = new StringBuilder();
            BigInteger result = 0;
            foreach (var c in input)
                {
                currLetter.Append(c);
                if (alpha.Contains(currLetter.ToString()))
                    {
                    int currDigit = Array.IndexOf(alpha, currLetter.ToString());
                    result *= 7;
                    result += currDigit;
                    currLetter.Clear();
                    }
                }
            Console.WriteLine(result);


            // КОНВЕРТИРАНЕ, ОСНОВЕН МЕТОД
            // user input
            Console.Write("Enter a number: ");
            string number = (Console.ReadLine()).ToUpper();
            Console.Write("Enter numberal system to convert From: ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Enter numberal system to convert To: ");
            int d = int.Parse(Console.ReadLine());
            // validation - input numbers are to be in the required range: (2 ≤ s, d ≤ 16)
            if (s < 2 || d < 2 || d > 16 || s > 16)
                {
                Console.WriteLine("Wrong input!Number should be in range [2 to 16]");
                }
            else
                {
                // applying the ConvertToDec(number, s) method on the input numbers,
                // and applying the DecimalToBase() method on the result
                Console.WriteLine(DecimalToBase(ConvertToDec(number, s), d));
                }
        }
        // converting all input numbers to decimal numeral system first
        public static int ConvertToDec(string number, int baseFrom)
            {
            int decNum = 0;
            for (int i = 0; i < number.Length; i++)
                {
                if (number[i] > '9') // if a char digit is > '9', it can only be 'A', 'B', etc.
                //from the hexadecimal numeral system
                    {
                    decNum += (number[i] - '7') * (int)Math.Pow(baseFrom, (number.Length - 1 - i));
                    // example: 'A' = 65 (ASCII code); '7' = 55; hence 'A' - '7' = 10,
                    // which is exactly the decimal representation of the digit A
                    }
                else
                    {
                    decNum += (number[i] - '0') * (int)Math.Pow(baseFrom, (number.Length - 1 - i));
                    // example: '9' = 57 (ASCII code); '0' = 48; hence '9' - '0' = 9,
                    // which is exactly the decimal value of the digit 9
                    }
                }
            return decNum;
            }
        public static string DecimalToBase(long decimalNumber, int numeralSystem)
            {
            string result = "";
            while (decimalNumber > 0)
                {
                // calculating remainder, after the input number
                // is divided by the number representing the numeral system
                // and we obtain the input number's digits
                long digit = decimalNumber % numeralSystem;
                if (digit >= 0 && digit <= 9)
                // example: '9' = 57 (ASCII code); '0' = 48; hence 9 - '0' = 9 + 48 = 57,
                // which is exactly the ASCII code of the char '9'
                // and the result is actually a string of chars, representing the separate digits of the number
                    {
                    result += (char)(digit + '0'); // we add one more char to the string representation of the number
                    }
                // if a digit is > 9, it can only be A, B, etc.
                //from the hexadecimal numeral system
                else
                    {
                    result += (char)(digit + '7');
                    // example: 'A' = 65 (ASCII code); '7' = 55; hence A + '7' = 10 + 55 = 65,
                    // which is exactly the ASCII code of the char 'A'
                    }
                // we divvide the decimal number by the number representing the numeral system,
                // so that we can re-apply the code below, and keep extracting digits,
                // until the decimal number has no more digits
                // and all its digits have been converted to chars,
                // and added to the string representation of the result number
                decimalNumber /= numeralSystem;
                }
            var reversed = result.Reverse(); // we will extract the digits in reversed order, so we need to reverse the order back to the correct one
            string output = string.Join("", reversed);
            return output;
        }

            // floating-point към Binary
        private class BinaryFloatingPoint
        {
            private static void Main()
            {
                float input;
                bool IsFloat;
                do
                {
                    IsFloat = float.TryParse(Console.ReadLine(), out input);
                    if (!IsFloat)
                        Console.WriteLine("Invalid input. Try again!");
                } while (!IsFloat);

                bool isNegative = false;
                if (input < 0.0f)
                {
                    input = -input;
                    isNegative = true;
                }

                byte mantissa = 127;
                double dInput = input;
                if (input > 2.0f)
                {
                    while (dInput >= 2.0)
                    {
                        mantissa++;
                        dInput = dInput/2.0d;
                    }
                }
                else
                {
                    while (dInput < 1.0)
                    {
                        mantissa--;
                        dInput = dInput*2.0d;
                    }
                }
                dInput = dInput - 1.0f;
                StringBuilder significant = new StringBuilder();
                for (int i = 0; i < 23; i++)
                {
                    dInput = dInput*2;
                    if (dInput >= 1.0d)
                    {
                        significant.Append('1');
                        dInput = dInput - 1.0f;
                    }
                    else
                    {
                        significant.Append('0');
                    }
                }
                Console.WriteLine("Sign: {0}, Mantissa: {1}, Exponent: {2}", (isNegative ? "-" : "+"),
                    Convert.ToString(mantissa, 2).PadLeft(8, '0'), significant);
            }

            // method to fill long array with chars
            private static string[] BuildDigits()
                {
                List<string> digits = new List<string>();
                for (char digit = 'A'; digit <= 'Z'; digit++)
                    {
                    digits.Add("" + digit);
                    }
                for (char prefix = 'a'; prefix <= 'z'; prefix++)
                    {
                    for (char suffix = 'A'; suffix <= 'Z'; suffix++)
                        {
                        string digit = "" + prefix + suffix;
                        digits.Add(digit);
                        }
                    }
                return digits.ToArray();
                }
        }

    }
}
    

