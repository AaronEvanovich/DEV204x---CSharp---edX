using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Description: Module Eight Assignment.
// Author: Javier Herrero Arnanz.

namespace Module_8_Assignment
{
    class Course
    {
        // Constants.
        private const int maxStudents = 3;
        private const int maxTeachers = 3;

        // Course variables and properties.
        public string CourseName { get; set; }
        public int CourseCredits { get; set; }
        private List<Student> students;
        private List<Teacher> teachers;

        // Constructor.
        public Course(string cName, int credits)
        {
            this.CourseName = cName;
            this.CourseCredits = credits;
            this.students = new List<Student>(maxStudents);
            this.teachers = new List<Teacher>(maxTeachers);
        }

        // Method to add a student.
        public void addStudent(Student student)
        {
            int n = this.students.Count;
            if (n < maxStudents)
            {
                this.students.Add(student);
            }
            else
            {
                Console.WriteLine("Array of students is full.");
            }
        }

        // Method to know the number of students.
        public int getStudentsNumber()
        {
            return this.students.Count;
        }

        // Method to know the names of the students and their grades.
        public void listStudents()
        {
            // Sort the array.
            this.students.Sort();

            foreach (Student s in this.students)
            {
                Console.WriteLine("{0} {1}", s.FirstName, s.LastName);
                s.showGrades();
                Console.WriteLine("\n");
            }
        }

        // Method to add a teacher.
        public void addTeacher(Teacher teacher)
        {
            int n = this.teachers.Count;
            if (n < maxTeachers)
            {
                this.teachers.Add(teacher);
            }
            else
            {
                Console.WriteLine("Array of teachers is full.");
            }
        }

        // Method to know the number of teachers.
        public int getTeacherNumber()
        {
            return this.teachers.Count;
        }
    }
}
