//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 

using System;
using System.Text;

using System;

class DeckOfCards
    {
    static void Main(string[] args)
        {
        string[] notations = { "spades", "clubs", "hearts", "diamonds" };
        string[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "K", "Q" };

        for (int i = 0; i < faces.Length; i++)
            {
            for (int j = 0; j < notations.Length; j++)
                {
                Console.Write("{0} of {1}", faces[i], notations[j]);
                if (j < notations.Length - 1)
                    {
                    Console.Write(", ");
                    }
                }
            Console.WriteLine();
            }
        }
    }
