/*Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file. Use StreamReader in combination with StreamWriter.*/

namespace _02.LineNumbers
    {
    using System;
    using System.IO;

    internal class LineNumbers
        {
        private static void Main()
            {
            StreamReader reader = new StreamReader("../../SomeTextFile.txt");

            using (reader)
                {
                string line = reader.ReadLine();

                StreamWriter writer = new StreamWriter("../../FinalText.txt");
                int lineNum = 0;
                using (writer)
                    {
                    while (line != null)
                        {
                        lineNum++;
                        writer.WriteLine("Line {0}: {1}", lineNum, line);
                        line = reader.ReadLine();
                        }
                    }
                }

            Console.WriteLine("The text has lines now:");
            Console.WriteLine();
            using (StreamReader resultReader = new StreamReader("../../FinalText.txt"))
                {
                while (!resultReader.EndOfStream) Console.WriteLine(resultReader.ReadLine());
                }
            }
        }
    }
