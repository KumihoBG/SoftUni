/*George likes math. Recently he discovered an interesting property of the Pythagorean Theorem: there are infinite number of triplets of integers a, b and c (a ≤ b), such that a2 + b2 = c2. Write a program to help George find all such triplets (called Pythagorean numbers) among a set of integer numbers.*/
// credits to Katya Marincheva

namespace _10.PythagoreanNumbers
    {
    using System;

    class PythagoreanNumbers
        {
        static void Main()
            {
            // input
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
                {
                numbers[i] = int.Parse(Console.ReadLine());
                }

            // logic
            bool PythagoreanNums = false;
            for (int n1 = 0; n1 < n; n1++)
                {
                for (int n2 = 0; n2 < n; n2++)
                    {
                    for (int n3 = 0; n3 < n; n3++)
                        {
                        int a = numbers[n1];
                        int b = numbers[n2];
                        int c = numbers[n3];
                        if (a <= b && (a * a + b * b == c * c))
                            {
                            // output option 1
                            Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", a, b, c);
                            PythagoreanNums = true;
                            }
                        }
                    }
                }

            // output option 2
            if (!PythagoreanNums)
                {
                Console.WriteLine("No");
                }
            }
        }
    }
