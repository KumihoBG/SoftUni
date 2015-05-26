namespace _01.ClassStudent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ query syntax.
    /// </summary>
    public static class StudentGroupsExtensions
    {
        /// <summary>
        /// A static extension method
        /// </summary>
        /// <param name="list">List of students</param>
        public static void GroupStudents(this IList<Student> list)
        {
            Console.WriteLine("Problem 5 -- > Sorting students by first and last names, using lambda expression: ");
            Console.WriteLine(new string('*', 81));
            var newGroup = list
                .OrderByDescending(s => s.FirstName)
                .ThenByDescending(s => s.LastName);

            foreach (var student in newGroup)
            {
                student.PrintStudents(Console.Out);
                Console.WriteLine();
            }
        }

        public static void QueryGroupingMethod(this IList<Student> list)
        {
            Console.WriteLine("The same grouping of students, with query syntax: ");
            Console.WriteLine(new string('*', 49));
            var groupedWithQuery =
                from student in list
                orderby student.FirstName descending,
                student.LastName descending
                select student;

            foreach (var student in groupedWithQuery)
            {
                student.PrintStudents(Console.Out);
                Console.WriteLine();
            }
        }
    }
}
