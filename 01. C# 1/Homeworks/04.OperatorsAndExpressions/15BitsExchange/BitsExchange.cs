//Problem 15.* Bits Exchange
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitsExchange
    {
    static void Main()
        {
        Console.Write("Enter an integer: ");
        uint number = uint.Parse(Console.ReadLine());
        uint result = number;

        for (int position = 3; position < 6; position++)
            {
            int changeTo = position + 21;
            uint moveSmallBit = number >> position;
            uint smallBit = moveSmallBit & 1;
            uint moveBigBit = number >> changeTo;
            uint bigBit = moveBigBit & 1;

            if (smallBit != bigBit)
                {
                uint maskSmall;
                if (smallBit == 0)
                    {
                    maskSmall = (uint)(1 << position);
                    result = result | maskSmall;
                    }
                else
                    {
                    maskSmall = (uint)(~(1 << position));
                    result = result & maskSmall;
                    }

                uint maskBig;
                if (bigBit == 0)
                    {
                    maskBig = (uint)(1 << changeTo);
                    result = result | maskBig;
                    }
                else
                    {
                    maskBig = (uint)(~(1 << changeTo));
                    result = result & maskBig;
                    }
                }

            }
        Console.WriteLine("Binary result: {0}", Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.WriteLine("Decimal result: {0}", result);
        }
    }
