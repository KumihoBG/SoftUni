using System;

namespace _13.Tables
    {
    class Tables
        {
        static void Main()
            {
            long bundle1 = long.Parse(Console.ReadLine());
            long bundle2 = long.Parse(Console.ReadLine());
            long bundle3 = long.Parse(Console.ReadLine());
            long bundle4 = long.Parse(Console.ReadLine());
            long tableTops = long.Parse(Console.ReadLine());
            long tablesToBeMade = long.Parse(Console.ReadLine());

            var legs = (bundle1 * 1) + (bundle2 * 2) + (bundle3 * 3) + (bundle4 * 4);

            long tablesMade = Math.Min((legs / 4), tableTops);
            long tableTopsNeeded = tablesToBeMade >= tableTops ? tablesToBeMade - tableTops : 0;
            long tableLegsNeeded = tablesToBeMade * 4 >= legs ? tablesToBeMade * 4 - legs : 0;
            long legsLeft = (legs - tablesToBeMade) / 4;
            long tableTopsLeft = tableTops - tablesToBeMade;

            if (tablesMade > tablesToBeMade)
                {
                Console.WriteLine("more: {0}", tablesMade - tablesToBeMade);
                Console.WriteLine("tops left: {0}, legs left: {1}", tableTopsLeft, legsLeft);
                }
            else if (tablesMade < tablesToBeMade)
                {
                Console.WriteLine("less: {0} ", tableTopsNeeded - tableTops);
                Console.WriteLine("tops needed: {0}, legs needed: {1}", tableTopsNeeded, tableLegsNeeded);
                }
            else
                {
                Console.WriteLine("Just enough tables made: {0}", tablesMade);
                }
            }
        }
    }
