using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LambdaExpressions
    {
    class Lambda
        {
        static void Main()
            {
            // ***************************************** Func
            Func<int, bool> func = n => n > 10; //функция, която приема като вход int, изходът е bool и резултатът се открива с ламда израз

            Action<string> action = Console.WriteLine;//функция, която не връща нищо е Console.WriteLine();

            //********************************** Пример за методи в Лист с използване на ламбда израз
            var numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(30);
            numbers.Add(50);
            numbers.Add(90);
            numbers.Add(10);
            numbers.Add(100);

            var result1 = numbers.Count(n => n > 10); //Методът Count може да изпълнява и ламбда изрази, дава брой числа, които отговарят на критерия

            var result = numbers.Where(n => n > 10); //Методът Where проверява/намира елементи по зададени критерии, принтира самите числа
            foreach (var item in result)
                {
                Console.WriteLine(item);
                }
            // от всички колекции само листът има и този метод:
            var result3 = numbers.FindAll(n => n % 2 == 0); //намира всички, които отговарят на критерия

            foreach (var item in result3)
                {
                Console.WriteLine(item);
                }
            var result4 = numbers.RemoveAll(x => x > 10);//премахва всички, които отговарят на критерия

            var pets = new List<string>();
            pets.Add("dog");
            pets.Add("cow");
            pets.Add("cat");
            pets.Add("dophin");

            var resultPets = pets.OrderBy(p => p.Length).ThenBy(p => p);
            foreach (var pet in resultPets)
                {
                Console.WriteLine(pet);
                }

            var students = new List<Student>();
            students.Add(new Student { FirstName = "A", LastName = "B", Age = 2 });
            students.Add(new Student { FirstName = "B", LastName = "E", Age = 5 });
            students.Add(new Student { FirstName = "C", LastName = "D", Age = 7 });
            students.Add(new Student { FirstName = "D", LastName = "C", Age = 11 });

            var studentsResult = students
                .Where(st => st.FirstName != "A") // дай ми всички студенти, чието име не започва с А
                .OrderBy(st => st.LastName) // подреди ми ги по фамилия
                .ThenBy(st => st.FirstName) // после по име
                .ThenByDescending(st => st.Age); // после по години в обратен ред
            foreach (var student in studentsResult)
                {
                Console.WriteLine(student);
                }

            var studentsNames = new List<string>();
            studentsNames.Add("Pesho");
            studentsNames.Add("Gosho");
            studentsNames.Add("Tosho");
            studentsNames.Add("Ivan");

            var newResult = studentsNames
                .Where(st => !st.Contains('o')) //дай ми всички, чиито имена не съдържат буквата О
                .Where(st => st[0] != 'P') // чиито имена не започват с буква П
                .OrderBy(st => st.Length); // и ми ги сортирай по дължина
            foreach (var item in newResult)
                {
                Console.WriteLine(item);
                }

            // both Array.Sort() and arr.OrderBy() methods can be used for sorting the array
            // you can test them if you uncomment one and comment the other
            //Array.Sort(arr, (x, y) => x.Length.CompareTo(y.Length));
            var query = arr.OrderBy(item => item.Length);
            string[] sorted = query.ToArray();
            }
        }

    class Student
        {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
        }
    }
