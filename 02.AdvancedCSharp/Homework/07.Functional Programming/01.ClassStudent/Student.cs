namespace _01.ClassStudent
    {
    using System.Collections.Generic;
    using System.IO;

        /// <summary>
    /// A class Student
    /// </summary>
    public class Student
        {
        private readonly List<Student> students;
        private string firstName;
        private string lastName;
        private int age;
        private string facultyNumber;
        private string phone;
        private string email;
        private string specialtyName;
        private int groupNumber;
        private IList<int> marks;

            /// <summary>
            /// Initializes a new instance of the <see cref="Student"/> class.
            /// </summary>
            /// <param name="firstName">first name</param>
            /// <param name="lastName">last name</param>
            /// <param name="age">age of the student</param>
            /// <param name="facultyNumber">faculty number</param>
            /// <param name="phone">telephone number</param>
            /// <param name="email">e-mail address</param>
            /// <param name="marks">marks and grading</param>
            /// <param name="groupNumber">the number of the group</param>
            /// <param name="specialtyName">the name of the department</param>
        public Student(string firstName, string lastName, int age, string facultyNumber, string phone, string email, IList<int> marks, int groupNumber, string specialtyName)
            {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.facultyNumber = facultyNumber;
            this.phone = phone;
            this.email = email;
            this.groupNumber = groupNumber;
            this.marks = marks;
            this.specialtyName = specialtyName;
            }

        /// <summary>
        /// Gets the property for the first name of the student
        /// </summary>
        public string FirstName
            {
            get { return this.firstName; }
            }

        /// <summary>
        /// Gets the property for the last name of the student
        /// </summary>
        public string LastName
            {
            get { return this.lastName; }
            }

        /// <summary>
        /// Gets the property for the age of the student
        /// </summary>
        public int Age
            {
            get { return this.age; }
            }

        /// <summary>
        /// Gets the property for the faculty number of the student
        /// </summary>
        public string FacultyNumber
            {
            get { return this.facultyNumber; }
            }

        /// <summary>
        /// Gets the property for the telephone of the student
        /// </summary>
        public string Phone
            {
            get { return this.phone; }
            }

        /// <summary>
        /// Gets the property for the e-mail of the student
        /// </summary>
        public string Email
            {
            get { return this.email; }
            }

        /// <summary>
        /// Gets the property for the mark of the student
        /// </summary>
        public IList<int> Mark
            {
            get { return this.marks; }
            }

        /// <summary>
        /// Gets the property for the group name of the student
        /// </summary>
        public int GroupNumber
            {
            get { return this.groupNumber; }
            }

        /// <summary>
        /// Gets the property for the department name of the student
        /// </summary>
        public string SpecialtyName
            {
            get { return this.specialtyName; }
            }

        public IEnumerable<Student> Students
            {
            get { return this.students; }
            }

        /// <summary>
        /// Initializes a group of students
        /// </summary>
        /// <param name="students">different students inside the group</param>
        public static void InitilaizeStudents(List<Student> students)
            {
            students.Add(new Student("Aleksandar", "Nikolov", 18, "802614", "02456789", "nikolov@abv.bg", new List<int> { 6, 5, 6 }, 1, "Web Developer"));
            students.Add(new Student("Petya", "Dimitrova", 23, "772422", "0989675432", "dimitrova@abv.bg", new List<int> { 4, 2, 5 }, 2, "PHP Developer"));
            students.Add(new Student("Penka", "Georgieva", 22, "802433", "+359 2675435", "georgieva@gmail.com", new List<int> { 5, 6, 6 }, 1, "C# Developer"));
            students.Add(new Student("Ekaterina", "Ivanova", 27, "567806", "0989768931", "ivanova@yahoo.com", new List<int> { 2, 3, 2 }, 2, "PHP Developer"));
            students.Add(new Student("Ivan", "Petrov", 26, "806714", "0888698034", "petrov@abv.bg", new List<int> { 6, 6, 6 }, 2, "QA Engineer"));
            students.Add(new Student("Petar", "Ivanov", 21, "6034106", "+3592 678654", "ivanov@gmail.com", new List<int> { 5, 5, 6 }, 1, "Web Developer"));
            students.Add(new Student("Yuri", "Aleksandrov", 30, "542314", "0989789654", "aleksandrov@abv.bg", new List<int> { 5, 4, 3 }, 1, "QA Engineer"));
            }

        /// <summary>
        /// Prints the students inside the selected group
        /// </summary>
        /// <param name="output">different properties of the student</param>
        public void PrintStudents(TextWriter output)
            {
            output.WriteLine("First name: {0}", this.FirstName);
            output.WriteLine("Last name: {0}", this.LastName);
            output.WriteLine("Age: {0}", this.age);
            output.WriteLine("Faculty Number: {0}", this.FacultyNumber);
            output.WriteLine("Phone: {0}", this.Phone);
            output.WriteLine("Email: {0}", this.Email);
            output.WriteLine("Marks: {0}", string.Join(", ", this.Mark));
            output.WriteLine("Group number: {0}", this.GroupNumber);
            output.WriteLine("Specialty name: {0}", this.SpecialtyName);
            }

        public void PrintYoungerStudents(TextWriter output)
            {
            output.WriteLine("First name: {0}", this.FirstName);
            output.WriteLine("Last name: {0}", this.LastName);
            output.WriteLine("Age: {0}", this.age);
            }
        }
    }