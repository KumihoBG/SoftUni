/*This problem is from the Java Basics Exam (1 June 2014). You may check your solution here.
You are given n numbers. Write a program to find among these numbers all sets of 4 numbers {a, b, c, d}, such that a|b == c|d, where a ≠ b ≠ c ≠ d. Assume that "a|b" means to append the number b after a. We call these numbers {a, b, c, d} stuck numbers: if we append a and b, we get the same result as if we appended c and d. Note that the numbers a, b, c and d should be distinct (a ≠ b ≠ c ≠ d).*/
// credits to Katya Marincheva

namespace _09.StuckNumbers
    {
    using System;

    class StuckNumbers
        {
        static void Main()
            {
            // input
            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            // logic
            bool stuckNums = false;
            for (int p1 = 0; p1 < n; p1++)
                {
                for (int p2 = 0; p2 < n; p2++)
                    {
                    for (int p3 = 0; p3 < n; p3++)
                        {
                        for (int p4 = 0; p4 < n; p4++)
                            {
                            if (p1 != p2 && p1 != p3 && p1 != p4 && p2 != p3 && p2 != p4 && p3 != p4)
                                {
                                // output option 1
                                stuckNums = CheckForStuckNumbers(numbers, p1, p2, p3, p4, stuckNums);
                                }
                            }
                        }
                    }
                }

            // ouput option 2
            if (!stuckNums)
                {
                Console.WriteLine("No");
                }
            }

        private static bool CheckForStuckNumbers(string[] numbers, int p1, int p2, int p3, int p4, bool stuckNums)
            {
            string left = numbers[p1] + numbers[p2];
            string right = numbers[p3] + numbers[p4];
            if (left == right)
                {
                PrintStuckNumbers(numbers, p1, p2, p3, p4);
                stuckNums = true;
                }
            return stuckNums;
            }

        private static void PrintStuckNumbers(string[] numbers, int p1, int p2, int p3, int p4)
            {
            Console.WriteLine("{0}|{1}=={2}|{3}", numbers[p1], numbers[p2], numbers[p3], numbers[p4]);
            }
        }
    }
