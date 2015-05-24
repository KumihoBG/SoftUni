namespace _14.SumOfElements
    {
    using System;

    internal class SumOfElements
        {
        private static void Main()
            {
            // the input
            string inputLine = Console.ReadLine();
            string[] newStringInput = inputLine.Split(' ');

            // finding the max value
            decimal max = decimal.MinValue;
            decimal sum = 0;
            foreach (string index in newStringInput)
                {
                decimal element = decimal.Parse(index);
                sum = sum + element;
                if (element > max)
                    {
                    max = element;
                    }
                }

            // checking if there is difference or not
            if (sum == 2 * max)
                {
                Console.WriteLine("Yes, sum={0}", max);
                }
            else
                {
                decimal diff = Math.Abs(sum - 2 * max);
                Console.WriteLine("No, diff={0}", diff);
                }
            }
        }
    }