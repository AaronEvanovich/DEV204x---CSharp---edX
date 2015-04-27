using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Description: Module Five Assignment.
// Author: Javier Herrero Arnanz.

namespace Module_5_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- Instantiate three Student objects.
            Student student1 = new Student("John","Snow",new DateTime(1990,10,22),"john@mail.com");
            Student student2 = new Student("Jaime", "Lanyster", new DateTime(1950, 03, 12), "jaime@mail.com");
            Student student3 = new Student("Walter", "White", new DateTime(1975, 12, 27), "walter@mail.com");

            // 2- Instantiate a Course object called Programming with C#.
            Course course = new Course("Programming with C#",15);

            // 3- Add your three students to this Course object.
            course.addStudent(student1);
            course.addStudent(student2);
            course.addStudent(student3);

            // 4- Instantiate at least one Teacher object.
            Teacher teacher = new Teacher("Jessie", "Pinkman", new DateTime(1985, 04, 03), "jessie@mail.com");
            
            // 5- Add that Teacher object to your Course object.
            course.addTeacher(teacher);

            // 6- Instantiate a Degree object, such as Bachelor.
            Degree degree = new Degree("Bachelor of Science", 250, null);

            // 7- Add your Course object to the Degree object.
            degree.Course = course;

            // 8- Instantiate a UProgram object called Information Technology.
            UProgram uProgram = new UProgram("Information Technology", "Gustavo Fring", null);
            
            // 9- Add the Degree object to the UProgram object.
            uProgram.Degree = degree;

            // 10- Output the information.
            Console.WriteLine("The {0} program contains the {1} degree\n",uProgram.ProgramName,degree.DegreeName);
            Console.WriteLine("The {0} degree contains the course {1}\n",degree.DegreeName,course.CourseName);
            Console.WriteLine("The {0} course contains {1} student(s)\n",course.CourseName,course.StudentsNumber);
        }

        private class Student
        {
            // Instances variables.
            private static int studentsCount = 0;

            // Student variables.
            private string firstName;
            private string lastName;
            private DateTime birthDate;
            private string email;

            // Constructor.
            public Student(string fName, string lName, DateTime birthDate, string email)
            {
                this.firstName = fName;
                this.lastName = lName;
                this.birthDate = birthDate;
                this.email = email;
                studentsCount++;
            }

            // Properties.
            public string FirstName
            {
                get { return this.firstName; }
                set { if (value != null) { this.firstName = value; } }
            }
            public string LastName
            {
                get { return this.lastName; }
                set { if (value != null) { this.lastName = value; } }
            }
            public DateTime BirthDate
            {
                get { return this.birthDate; }
                set { if (value != null) { this.birthDate = value; } }
            }
            public string Email
            {
                get { return this.email; }
                set { if (value != null) { this.email = value; } }
            }
        }

        private class Teacher
        {
            // Teacher variables.
            private string firstName;
            private string lastName;
            private DateTime birthDate;
            private string email;

            // Constructor.
            public Teacher(string fName, string lName, DateTime birthDate, string email)
            {
                this.firstName = fName;
                this.lastName = lName;
                this.birthDate = birthDate;
                this.email = email;
            }

            // Properties.
            public string FirstName {
                get { return this.firstName; }
                set { if (value != null) { this.firstName = value; } } 
            }
            public string LastName {
                get { return this.lastName; }
                set { if (value != null) { this.lastName = value; } } 
            }
            public DateTime BirthDate {
                get { return this.birthDate; }
                set { if (value != null) { this.birthDate = value; } } 
            }
            public string Email {
                get { return this.email; }
                set { if (value != null) { this.email = value; } } 
            }
        }

        private class UProgram
        {
            // UProgram variables.
            private string programName;
            private string departmentHead;
            private Degree degree;

            // Constructor.
            public UProgram(string pName, string departmentH, Degree degree)
            {
                this.programName = pName;
                this.departmentHead = departmentH;
                this.degree = degree;
            }

            // Properties.
            public string ProgramName {
                get { return this.programName; }
                set { if (value != null) { this.programName = value; } } 
            }
            public string DepartmentHead {
                get { return this.departmentHead; }
                set { if (value != null) { this.departmentHead = value; } } 
            }
            public Degree Degree {
                get { return this.degree; }
                set { if (value != null) { this.degree = value; } } 
            }
        }

        private class Degree
        {
            // Degree variables.
            private string degreeName;
            private int totalCredits;
            private Course course;

            // Constructor.
            public Degree(string dName, int credits, Course course)
            {
                this.degreeName = dName;
                this.totalCredits = credits;
                this.course = course;
            }

            // Properties.
            public string DegreeName {
                get { return this.degreeName; }
                set { if (value != null) { this.degreeName = value; } } 
            }
            public int TotalCredits {
                get { return this.totalCredits; }
                set { if (value != null) { this.totalCredits = value; } } 
            }
            public Course Course {
                get { return this.course; }
                set { if (value != null) { this.course = value; } } 
            }
        }

        private class Course
        {
            // Constants.
            private static int maxArraySize = 3;

            // Course variables.
            private string courseName;
            private int courseCredits;
            private Student[] students;
            private int studentsNumber;
            private Teacher[] teachers;
            private int teachersNumber;

            // Constructor.
            public Course(string cName, int credits)
            {
                this.courseName = cName;
                this.courseCredits = credits;
                this.students = new Student[maxArraySize];
                this.studentsNumber = 0;
                this.teachers = new Teacher[maxArraySize];
                this.teachersNumber = 0;
            }

            // Properties.
            public string CourseName {
                get { return this.courseName; }
                set { if (value != null) { this.courseName = value; } } 
            }
            public int CourseCredits {
                get { return this.courseCredits; }
                set { if (value != null) { this.courseCredits = value; } }
            }
            public int StudentsNumber
            {
                get { return this.studentsNumber; }
            }
            public int TeachersNumber
            {
                get { return this.teachersNumber; }
            }

            // Method to add a student.
            public void addStudent(Student student)
            {
                int n = this.StudentsNumber;
                if (n < maxArraySize)
                {
                    this.students[n] = student;
                    this.studentsNumber++;
                }
                else
                {
                    Console.WriteLine("Array of students is full.");
                }
            }

            // Method to add a teacher.
            public void addTeacher(Teacher teacher)
            {
                int n = this.TeachersNumber;
                if (n < maxArraySize)
                {
                    this.teachers[n] = teacher;
                    this.teachersNumber++;
                }
                else
                {
                    Console.WriteLine("Array of teachers is full.");
                }
            }
        }
    }
}
