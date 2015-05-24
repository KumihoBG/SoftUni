/*Write a program that reads a sequence of integers and finds in it the longest non-decreasing subsequence. In other words, you should remove a minimal number of numbers from the starting sequence, so that the resulting sequence is non-decreasing. In case of several longest non-decreasing sequences, print the leftmost of them. The input and output should consist of a single line, holding integer numbers separated by a space.*/

/* The solving of the task is still in progress :) */

namespace _08.LongestNonDecreasingSubsequence
{
    using System;

    internal class LongestNonDecreasingSubsequence
    {
        private static void Main()
        {
            Console.WriteLine("Enter the input numbers of the array, separated by comma and/or space: ");
            string input = Console.ReadLine();
            char[] split = {',', ' '};
            string[] text = input.Split(split, StringSplitOptions.RemoveEmptyEntries);

            int[] newArray = new int[text.Length];  
            for (int i = 0; i < text.Length; i++)   
                {
                newArray[i] = int.Parse(text[i]);
                }

            int maxSequence = 0;
            int start = 0;
            for (int i = 0; i < newArray.Length; i++)   
                {
                int currentNumber = 0;                  
                int j = i;                              

                while (newArray[i] == newArray[j]) 
                    {
                    currentNumber++;
                    j++;
                    if (j >= newArray.Length)   
                        {
                        break;
                        }
                    }

                if (currentNumber > maxSequence)
                    {
                    maxSequence = currentNumber;
                    start = i;
                    }
                }

            for (int i = start; i <= start + maxSequence - 1; i++)
                {
                if (i != start + maxSequence - 1)
                    {
                    Console.Write(newArray[i] + " "); 
                    }
                else
                    {
                    Console.WriteLine(newArray[i]); 
                    }
                }
            }
        }
    }
