/* A marketing company wants to keep record of its employees. Each record would have the following characteristics:
•	First name
•	Last name
•	Age (0...100)
•	Gender (m or f)
•	Personal ID number (e.g. 8306112507)
•	Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.*/

namespace _10.EmployeeData
    {
    using System;

    class EmployeeData
        {
        static void Main()
            {
            const string firstName = "John";
            const string lastName = "Doe";
            const byte age = 45;
            const string gender = "m";
            const string personalId = "8306112507";
            const int uniqueNumber = 27569898;
            Console.WriteLine("The employee information is, as follows:");
            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID number: {0}", personalId);
            Console.WriteLine("Unique employee number: {0}", uniqueNumber);
            }
        }
    }
