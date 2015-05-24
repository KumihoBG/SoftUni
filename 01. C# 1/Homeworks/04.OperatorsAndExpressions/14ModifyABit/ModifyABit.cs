/*Problem 14. Modify a Bit at Given Position
We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the 
binary representation of n while preserving all other bits in n.*/

using System;

class ModifyABit
    {
    static void Main()
        {
        Console.Write("Enter an integer number: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter index p: ");
        int indexP = int.Parse(Console.ReadLine());
        Console.Write("Enter value 0 or 1 for the bit at index p: ");
        int bitValue = int.Parse(Console.ReadLine());

        Console.WriteLine("The binary representation of the number is: {0}", Convert.ToString(numberN, 2).PadLeft(16, '0'));

        int mask;
        int result;
        if (bitValue == 0)
            {
            mask = ~(1 << indexP);
            result = numberN & mask;
            }
        else
            {
            mask = bitValue << indexP;
            result = numberN | mask;
            }

        Console.Write("Binary result: ");
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(16, '0'));
        Console.Write("Decimal result: ");
        Console.WriteLine(result);
        }
    }