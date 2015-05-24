using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PiggyBank
    {
    internal class PiggyBank
        {
        private static void Main()
            {
            long price = long.Parse(Console.ReadLine());
            byte partyDays = byte.Parse(Console.ReadLine());

            if (partyDays > 8)
                {
                Console.WriteLine("never");
                }
            else
                {
                int normalDays = 30 - partyDays;

                int monthlySavings = normalDays * 2;
                int monthlyExpenses = partyDays * 5;
                int monthlyBalance = monthlySavings - monthlyExpenses;

                double totalMonthsRequired = (double)price / monthlyBalance;
                int result = (int)Math.Ceiling(totalMonthsRequired); // Returns the smallest integral value that is 
                int years = result / 12;                             // greater than or equal to the specified 
                int months = result % 12;							 // double-precision floating-point number.
                Console.WriteLine("{0} years, {1} months", years, months);
                }
            }
        }
    }
