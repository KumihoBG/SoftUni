namespace _03.LettersChangeNumbers
    {
    using System;
    using System.Linq;

    internal class LettersChangeNumbers
        {
        private static void Main()
            {
            string input = Console.ReadLine();
            string[] words = input.Split(' ').ToArray();
            double totalSum = 0;
            string firstArray = words[0];
            if (words.Length <= 1)
                {
                string firstNumber = firstArray.Substring(1, firstArray.Length - 1);
                double numberOne = Convert.ToDouble(firstNumber.Remove(firstNumber.Length - 1, 1));
                char firstOne = Convert.ToChar(firstArray.Substring(0, 1));
                char secondOne = Convert.ToChar(firstArray.Substring(firstNumber.Length, 1));
                double finalResult = 0;
                numberOne = ExecuteFirstChar(firstOne, numberOne);
                numberOne = ExecuteSecondChar(secondOne, numberOne);
                finalResult = numberOne;
                Console.WriteLine("{0:f2}", finalResult);
                }
            else
                {
                double finalResult = 0;
                    foreach (var array in words)
                    {
                        
                        //string firstNumber = array.Substring(1, array.Length - 1);
                        //string secondNumber = array.Substring(1, array.Length - 1);
                        //double numberOne = Convert.ToDouble(firstNumber.Remove(firstNumber.Length - 1, 1));
                        //double numberTwo = Convert.ToDouble(secondNumber.Remove(secondNumber.Length - 1, 1));
                        //char firstOne = Convert.ToChar(array.Substring(0, 1));
                        //char firstTwo = Convert.ToChar(array.Substring(0, 1));
                        //char secondOne = Convert.ToChar(array.Substring(firstNumber.Length, 1));
                        //char secondTwo = Convert.ToChar(array.Substring(secondNumber.Length, 1));
                        double number = Convert.ToDouble(array.Substring(1, array.Length - 1));
                        number = ExecuteFirstChar((char) 0, number);
                        number = ExecuteSecondChar((char) (words.Length - 1), number);
                        finalResult += number;
                    }
                    Console.WriteLine("{0:f2}", finalResult);
                }
            }

        private static double ExecuteFirstChar(char c, double number)
            {
            if (c >= 65 && c <= 90)
                {
                return number / (c - 64);
                }
            else
                {
                return number * (c - 96);
                }
            }

        private static double ExecuteSecondChar(char c, double number)
            {
            if (c >= 65 && c <= 90)
                {
                return number - (c - 64);
                }
            else
                {
                return number + (c - 96);
                }
            }
        }
    }
