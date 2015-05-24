/* Find online more information about ASCII (American Standard Code for Information Interchange) and write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255). Note that some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently. You may need to use for-loops (learn in Internet how).*/

namespace _14.PrintASCIITable
    {
    using System;
    using System.Text;

    class PrintAsciiTable
        {
        static void Main()
            {
            Console.OutputEncoding = Encoding.Unicode;
            int column = 0;
            for (byte counter = 0; counter < 255; counter++) // using for - loop to print the table
                {
                if (column == 0) // using if-else conditional statement to make columns
                    {
                    Console.Write((char)counter + " " + "|" + " ");
                    }
                Console.Write((char)counter + " " + "|" + " ");
                if (++column > 16)
                    {
                    column = 0;
                    Console.WriteLine();
                    }
                }
            }
        }
    }
