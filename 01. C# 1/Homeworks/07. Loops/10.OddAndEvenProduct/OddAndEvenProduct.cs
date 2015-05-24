//You are given n integers (given in a single line, separated by a space).
// Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
// Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

namespace OddAndEvenProduct
    {
    class OddAndEvenProduct
        {
        static void Main()
            {
            Console.Write("Please, enter some numbers in a line, separated by a space: ");
            string numbers = Console.ReadLine();
            string[] numStr = numbers.Split(' ');
            int odd = 1;
            int even = 1;
            for (int i = 0; i < numStr.Length; i++)
                {
                int number;
                bool isNumber = int.TryParse(numStr[i], out number);
                if (isNumber)
                    {
                    if (i % 2 != 0)
                        {
                        odd *= number;
                        }
                    else if (i % 2 == 0)
                        {
                        even *= number;
                        }
                    }
                }
            if (even == odd)
                {
                Console.WriteLine("The product is = {0}", even);
                Console.WriteLine("Yes, the product is even.");
                }
            else
                {
                Console.WriteLine("The even product is = {0}\nThe odd product is = {1}",
                    even, odd);
                Console.WriteLine("No, the product is not even.");
                }
            }
        }
    }
