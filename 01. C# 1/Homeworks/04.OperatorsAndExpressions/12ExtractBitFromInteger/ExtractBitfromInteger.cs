//Problem 12. Extract Bit from Integer
//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitfromInteger
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter index p: ");
        int indexP = int.Parse(Console.ReadLine());
        Console.Write("The binary representation of the number is: ");
        Console.WriteLine(Convert.ToString(numberN, 2).PadLeft(16, '0'));
        int moveNumberN = numberN >> indexP;
        int bit = moveNumberN & 1;
        Console.WriteLine("The value of the given bit at index p is: {0}", Convert.ToString(bit, 2));
    }
}

