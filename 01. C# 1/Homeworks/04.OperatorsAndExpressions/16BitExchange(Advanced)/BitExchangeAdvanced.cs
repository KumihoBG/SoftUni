/*Problem 16.** Bit Exchange (Advanced)
Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
The first and the second sequence of bits may not overlap.*/

using System;

class BitExchangeAdvanced
    {
    static void Main()
        {
        Console.Write("Enter an integer number: ");
        string num = Console.ReadLine();
        uint number;
        if (!uint.TryParse(num, out number))
            {
            Console.WriteLine("out of range");
            }
        else
            {
            // calling the method from below
            EnterWriteData(number);
            }
        }

    // declaring a method for the input of the data
    private static void EnterWriteData(uint number)
        {
        Console.Write("Enter bit p: ");
        int bitP = int.Parse(Console.ReadLine());
        Console.Write("Enter bit q: ");
        int bitQ = int.Parse(Console.ReadLine());
        Console.Write("Enter the length of the sequence: ");
        int lengthK = int.Parse(Console.ReadLine());

        if (bitP < 0 || bitQ < 0 || lengthK < 0)
            {
            Console.WriteLine("out of range");
            }
        else if (Math.Abs(bitP - bitQ) < lengthK)
            {
            Console.WriteLine("overlapping");
            }
        else if (bitQ + lengthK > 32 || bitP + lengthK > 32)
            {
            Console.WriteLine("out of range");
            }
        else
            {
            uint result = ExchangeBits(number, bitP, bitQ, lengthK);
            Console.WriteLine("Binary result: {0}", Convert.ToString(result, 2).PadLeft(32, '0'));
            Console.WriteLine("Decimal result {0}", result);
            }
        }

    // declaring a method for the exchange of the bits
    private static uint ExchangeBits(uint number, int bitP, int bitQ, int lengthK)
        {
        uint result = number;
        for (int position = bitP; position < bitP + lengthK; position++)
            {
            uint moveSmallBit = number >> position;
            uint smallBit = moveSmallBit & 1;
            uint moveBigBit = number >> bitQ;
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
                    maskBig = (uint)(1 << bitQ);
                    result = result | maskBig;
                    }
                else
                    {
                    maskBig = (uint)(~(1 << bitQ));
                    result = result & maskBig;
                    }
                }
            bitQ++;
            }
        return result;
        }
    }