using System;
using System.Linq;

namespace _18.PinValidation___array___strings
    {
    internal class PinValidation
        {
        private static void Main()
        {
            // input names 
            string[] names = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            // validate names
            if (ValidateNames(names)) return;

            // input gender
            string gender = Console.ReadLine();

            // input PIN
            string pin = Console.ReadLine();

            // read month
            int month = int.Parse(pin.Substring(2, 2));

            // read year last digits
            int year = int.Parse(pin.Substring(0, 2));

            if (ValidateMonthAndYear(ref month, ref year)) return;

            // read and validate day
            int day = int.Parse(pin.Substring(4, 2));

            if (ValidateDays(day, year, month)) return;

            // validate gender digit
            if (ValidateGenderDigit(gender, pin)) return;

            if (ChecksumValidation(pin)) return;

            // print result
            Console.WriteLine("{{\"name\":\"{0}\",\"gender\":\"{1}\",\"pin\":\"{2}\"}}", string.Join(" ", names), gender,
                pin);
        }

        private static bool ChecksumValidation(string PIN)
            {
            int[] digits = PIN.ToCharArray().Select(x => x - '0').ToArray();

            int[] factors = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            int sum = factors.Select((t, i) => digits[i]*t).Sum();

            int checksum = sum % 11;
            checksum = checksum < 10 ? checksum : 0;
            if (checksum != digits[9])
                {
                Console.WriteLine("<h2>Incorrect data</h2>");
                return true;
                }
            return false;
            }

        private static bool ValidateGenderDigit(string gender, string PIN)
            {
            if ((gender == "female" && (PIN[8] - '0') % 2 == 0) || (gender == "male" && (PIN[8] - '0') % 2 != 0))
                {
                Console.WriteLine("<h2>Incorrect data</h2>");
                return true;
                }
            return false;
            }

        private static bool ValidateDays(int day, int year, int month)
            {
            if (day < 1 || day > DateTime.DaysInMonth(year, month))
                {
                Console.WriteLine("<h2>Incorrect data</h2>");
                return true;
                }
            return false;
            }

        private static bool ValidateNames(string[] names)
            {
            if (names.Length != 2)
                {
                Console.WriteLine("<h2>Incorrect data</h2>");
                return true;
                }

            if (names.Any(t => !char.IsUpper(t.First())))
                {
                Console.WriteLine("<h2>Incorrect data</h2>");
                return true;
                }
            return false;
            }

        private static bool ValidateMonthAndYear(ref int month, ref int year)
            {
            // validate month and calculate year first digits
            if (month >= 20 && month <= 32)
                {
                year += 1800;
                month -= 20;
                }
            else if (month >= 1 && month <= 12)
                {
                year += 1900;
                }
            else if (month >= 40 && month <= 52)
                {
                year += 2000;
                month -= 40;
                }
            else
                {
                Console.WriteLine("<h2>Incorrect data</h2>");
                return true;
                }
            return false;
            }
        }
    }
