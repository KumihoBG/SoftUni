// Create a class Student with properties FirstName, LastName, Age, FacultyNumber, Phone, Email, Marks (IList<int>), GroupNumber. Create a List<Student> with sample students. These students will be used for the next few tasks.
// IMPORTANT: Please, resize your console size in case the results are not printed correctly. Ex.500 x 500

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ClassStudent
    {
    /// <summary>
    /// A class for the group of students
    /// </summary>
    public class StudentGroupMain
        {
        /// <summary>
        /// The main method
        /// </summary>
        public static void Main()
            {
            List<Student> groupOfStudents = new List<Student>();
            Student.InitilaizeStudents(groupOfStudents);

            // Problem 2 - Print all students from group number 2. Use a LINQ query. Order the students by FirstName.
            var groupTwo = groupOfStudents
                .Where(s => s.GroupNumber == 2)
                .OrderBy(s => s.FirstName);
            Console.WriteLine("Problem 2 -- > The list of the students in group No 2, sorted by their first names: ");
            Console.WriteLine(new string('*', 83));

            foreach (var person in groupTwo)
                {
                person.PrintStudents(Console.Out);
                Console.WriteLine();
                }

            // Problem 3 - Print all students whose first name is before their last name alphabetically. Use a LINQ query.
            var listOfNames = groupOfStudents.Where(s => string.Compare(s.FirstName, s.LastName, StringComparison.Ordinal) < 0);
            Console.WriteLine("Problem 3 -- > The list of the students whose first name is before their last name alphabetically: ");
            Console.WriteLine(new string('*', 98));

            foreach (var person in listOfNames)
                {
                person.PrintStudents(Console.Out);
                Console.WriteLine();
                }

            // Problem 4 - Write a LINQ query that finds the first name and last name of all students with age between 18 and 24. The query should return only the first name, last name and age.
            var youngerStudents = groupOfStudents.Where(s => s.Age >= 18 && s.Age <= 24);
            Console.WriteLine("Problem 4 -- > The list of the students with age between 18 and 24: ");
            Console.WriteLine(new string('*', 67));

            foreach (var person in youngerStudents)
                {
                person.PrintYoungerStudents(Console.Out);
                Console.WriteLine();
                }

            // Problem 5 
            groupOfStudents.GroupStudents();
            groupOfStudents.QueryGroupingMethod();

            // Problem 6  - Print all students that have email @abv.bg. Use LINQ.
            Console.WriteLine("Problem 6 -- > The list of the students that have email in abv.bg: ");
            Console.WriteLine(new string('*', 66));

            var selectedStudents =
                from student in groupOfStudents
                where student.Email.Substring(student.Email.IndexOf("@", StringComparison.Ordinal) + 1) == "abv.bg"
                select student;

            foreach (var person in selectedStudents)
                {
                person.PrintStudents(Console.Out);
                Console.WriteLine();
                }

            // Problem 7 - Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). Use LINQ.
            Console.WriteLine("Problem 7 -- > The list of the students that have phones in Sofia: ");
            Console.WriteLine(new string('*', 66));

            var studentsByPhone =
                from student in groupOfStudents
                where student.Phone.StartsWith("02")
                || student.Phone.StartsWith("+3592")
                || student.Phone.StartsWith("+359 2")
                select student;

            foreach (var person in studentsByPhone)
                {
                person.PrintStudents(Console.Out);
                Console.WriteLine();
                }

            // Problem 8 - Print all students that have at least one mark Excellent (6). Using LINQ first select them into a new anonymous class that holds { FullName + Marks}.
            Console.WriteLine("Problem 8 -- > The list of the students that have at least one mark Excellent(6): ");
            Console.WriteLine(new string('*', 81));
            var studentsByMarks =
                from student in groupOfStudents
                where student.Mark.Contains(6)
                select new { Fullname = string.Join(" ", student.FirstName, student.LastName), Marks = string.Join(" ", student.Mark) };

            foreach (var person in studentsByMarks)
                {
                Console.WriteLine(person.Fullname + " " + person.Marks);
                }
            Console.WriteLine();

            // Problem 9 - Write down a similar program that extracts the students with exactly two marks "2". Use extension method.
            groupOfStudents.ExtractStudents();

            // Problem 10 - Extract and print the Marks of the students that enrolled in 2014 (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).
            Console.WriteLine("Problem 10 -- > The list with students enrolled in 2014 and their marks: ");
            Console.WriteLine(new string('*', 72));
            var studentsByYear =
                from student in groupOfStudents
                where student.FacultyNumber.EndsWith("14")
                select student;

            foreach (var person in studentsByYear)
                {
                Console.WriteLine("{0} {1} {2}", person.FirstName, person.LastName, string.Join(" ", person.Mark));
                }
            Console.WriteLine();

            // Problem 11 - Add a GroupName property to Student. Write a program that extracts all students grouped by GroupName and then prints them on the console. Print all group names along with the students in each group. Use the "group by into" LINQ operator.
            Console.WriteLine("Problem 11* -- > The list of the students extracted by group name: ");
            Console.WriteLine(new string('*', 66));

            var groupNames =
                from someGroup in groupOfStudents
                group someGroup by someGroup.SpecialtyName
                into newgroup
                select newgroup;

            foreach (var studentGroupName in groupNames)
                {
                Console.WriteLine("Group Name: {0}, Number of Students: {1}", studentGroupName.Key, studentGroupName.Count());
                foreach (var student in studentGroupName)
                    {
                    Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
                    }
                Console.WriteLine();
                }

            // printing the whole list of students in case the user chooses so:
            Console.WriteLine("Would you like to see the whole list of students? Y/N?");

            while (true)
                {
                string overwrite = Console.ReadLine();
                if (overwrite.ToUpper().Equals("Y"))
                    {
                    Console.WriteLine();
                    Console.WriteLine("The full list of the students: ");
                    Console.WriteLine(new string('*', 30));
                    foreach (var person in groupOfStudents)
                        {
                        person.PrintStudents(Console.Out);
                        Console.WriteLine();
                        }

                    break;
                    }
                else if (overwrite.ToUpper().Equals("N"))
                    {
                    Console.WriteLine("Thank you for your choice. Good bye!");
                    break;
                    }
                else
                    {
                    Console.WriteLine("This is not a valid choice");
                    overwrite = Console.ReadLine();
                    }
                }
            }
        }
    }