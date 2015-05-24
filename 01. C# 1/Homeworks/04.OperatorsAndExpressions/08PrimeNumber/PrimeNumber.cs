/* Problem 8. Prime Number Check
Write an expression that checks if given positive integer number n (n <= 100) is prime
(i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive */

using System;

class PrimeNumber
    {
    static void Main()
        {
        Console.WriteLine("Enter positive integer number between 2 and 100");
        int number = int.Parse(Console.ReadLine());
        while (number < 2 || number > 100)
            {
            Console.WriteLine("Try again");
            number = int.Parse(Console.ReadLine());
            }
        bool isPrime = true;
        int counter = 1;
        while (counter <= Math.Sqrt(number))
            {
            if (number % counter == 0 && counter > 1)
                {
                isPrime = false;
                }
            counter++;
            }
        Console.WriteLine("Is the number prime? {0}", isPrime);
        }
    }

