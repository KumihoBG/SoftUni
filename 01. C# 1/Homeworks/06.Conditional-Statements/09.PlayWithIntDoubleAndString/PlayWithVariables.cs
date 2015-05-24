/* Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/

namespace PlayWithIntDoubleAndString
    {
    using System;
    using System.Threading;
    using System.Globalization;

    internal class PlayWithVariables
        {
        private static void Main()
            {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please, choose a type: ");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
                {
                case 1:
                    Console.WriteLine("Please, enter an integer: ");
                    int firstChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine(firstChoice + 1);
                    break;
                case 2:
                    Console.WriteLine("Please, enter a double: ");
                    double secondChoice = double.Parse(Console.ReadLine());
                    Console.WriteLine(secondChoice + 1);
                    break;
                case 3:
                    Console.WriteLine("Please, enter a string: ");
                    string thirdChoice = Console.ReadLine();
                    Console.WriteLine(thirdChoice + "*");
                    break;
                default:
                    Console.WriteLine("This is invalid choice. Try again!");
                    break;
                }
            }
        }
    }