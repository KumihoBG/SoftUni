/*Write a program that reads a text file and prints on the console its odd lines. Line numbers starts from 0. Use StreamReader.*/

namespace _01.OddLines
    {
    using System;
    using System.IO;
    using System.Text;

    internal class OddLines
        {
        private static void Main()
            {
            try
                {
                StreamReader reader = new StreamReader(@"..\..\OddLines.cs", Encoding.GetEncoding("windows-1251"));

                int lineNumber = 0;

                using (reader)
                    {
                    string s;
                    do
                        {
                        s = reader.ReadLine();
                        lineNumber++;
                        s = reader.ReadLine();
                        Console.WriteLine("Line {0, 2}: {1}", lineNumber, s);
                        lineNumber++;
                        } while (s != null);
                    }
                }

            catch (FileNotFoundException)
                {
                Console.WriteLine("File not found.");
                }
            }
        }
    }