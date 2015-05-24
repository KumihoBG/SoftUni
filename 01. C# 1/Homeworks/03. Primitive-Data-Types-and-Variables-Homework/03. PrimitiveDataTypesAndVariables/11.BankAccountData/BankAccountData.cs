/* A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.*/

namespace _11.BankAccountData
    {
    using System;

    class BankAccountData
        {
        static void Main()
            {
            const string firstName = "Ivan";
            const string middleName = "Petrov";
            const string lastName = "Ivanov";
            const string holderName = firstName + " " + middleName + " " + lastName;
            const decimal balance = (decimal)1846.65;
            const string bankName = "Bulgarian Bank SA";
            const string iban = "BG45 BBGSF 4987 6345 78";
            const string creditCard1 = "4934580187";
            const string creditCard2 = "5637876102";
            const string creditCard3 = "2546785432";
            Console.WriteLine("Bank account details:");
            Console.WriteLine("Holder name: {0}", holderName);
            Console.WriteLine("Current balance: {0:C}", balance);
            Console.WriteLine("Bank name: {0}", bankName);
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("Credit cards numbers: No.(1) {0}, No.(2) {1} and No.(3) {2}", creditCard1, creditCard2, creditCard3);
            }
        }
    }
