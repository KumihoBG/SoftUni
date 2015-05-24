/* Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic. Print the variable values before and after the exchange.*/

namespace _09.ExchangeVariablesValues
    {
    using System;

    class ExchangeVariablesValues
        {
        static void Main()
            {
            int a = 5;
            int b = 10;
            a ^= b; // using assignment operator
            b ^= a;
            a ^= b;
            Console.WriteLine("The initial value of \"a\" is 5");
            Console.WriteLine("The initial value of \"b\" is 10");
            Console.WriteLine("The new value of \"a\" is: " + a);
            Console.WriteLine("The new value of \"b\" is: " + b);
            }
        }
    }
