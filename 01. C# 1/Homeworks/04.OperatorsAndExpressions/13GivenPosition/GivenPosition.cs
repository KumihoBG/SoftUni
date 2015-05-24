/*Problem 13. Check a Bit at Given Position
Write a Boolean expression that returns if the bit at position p 
(counting from 0, starting from the right) in given integer number n, has value of 1.*/

using System;

class GivenPosition
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
        bool isBitValue1 = (moveNumberN & 1) == 1;

        Console.WriteLine("Does the bit at position p have value 1? {0}", isBitValue1);
        }
    }