/* Problem 11. Bitwise: Extract Bit #3
Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.*/ 

using System;

class BitwiseExtractBit
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.Write("The Binary representation of the number is: ");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        uint moveNumber = number >> 3;
        uint bit = moveNumber & 1;
        Console.WriteLine("The value of the bit #3 is: {0}", Convert.ToString(bit, 2));
    }
}


