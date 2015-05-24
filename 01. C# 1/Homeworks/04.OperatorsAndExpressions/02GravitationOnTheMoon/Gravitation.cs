/*Problem 2. Gravitation on the Moon
The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 
Examples:
weight	weight on the Moon
86	14.62
74.6	12.682
53.7	9.129*/

using System;

class Gravitation
    {
    static void Main()
        {
        Console.Write("Enter the weight of a man on the Earth: ");
        float weight = float.Parse(Console.ReadLine());
        Console.WriteLine("The weight of a man on the Moon will be: " + weight * 0.17 + " kg");
        }
    }

