namespace _16.HalfSum
    {
    using System;

    class HalfSum
        {
        static void Main()
            {
            int countOfNumbers = int.Parse(Console.ReadLine());

            int number = 0;
            int numberTwo = 0;
            int sum = 0;
            int sumTwo = 0;
            int lines = 2 * countOfNumbers;

            for (int i = 0; i < lines / 2; i++)
                {
                number = int.Parse(Console.ReadLine());
                numberTwo = number;
                sum += numberTwo;
                }
            for (int k = lines / 2; k < lines; k++)
                {
                number = int.Parse(Console.ReadLine());
                numberTwo = number;
                sumTwo += numberTwo;
                }

            if (sum == sumTwo)
                {
                Console.WriteLine("Yes, sum={0}", sum);
                }
            else if (sum < sumTwo)
                {
                Console.WriteLine("No, diff={0}", sumTwo - sum);
                }
            else
                {
                Console.WriteLine("No, diff={0}", sum - sumTwo);
                }
            }
        }
    }
