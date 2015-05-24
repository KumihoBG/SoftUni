/*Define a method Fib(n) that calculates the nth Fibonacci number.*/

namespace _01.FibonacciNumbers
{
    using System;
    using System.Numerics;

    internal class FibonacciNumbers
    {
        private static void Main()
        {
        double n;
        BigInteger fibN;
        double phi = (1 + Math.Sqrt(5)) / 2;

        do 
            {
            Console.Write("Please, enter an integer value for n: ");
            } while (!double.TryParse(Console.ReadLine(), out n) || n <= 0);

        FinN(phi, n, out fibN);
        }

        private static void FinN(double phi, double n, out BigInteger fibN)
        {
            fibN = (BigInteger) Math.Round((Math.Pow(phi, n + 1) - Math.Pow((1 - phi), n + 1))/Math.Sqrt(5));
            Console.WriteLine("n: {0}, Fib(n): {1}", n, fibN);
        }
    }
}
