using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Description: Module Seven Assignment.
// Author: Javier Herrero Arnanz.

namespace Module_7_Assignment
{
    class Course
    {
        // Constants.
        private static int maxStudents = 3;
        private static int maxTeachers = 3;

        // Course variables and properties.
        public string CourseName { get; set; }
        public int CourseCredits { get; set; }
        private ArrayList students;
        private ArrayList teachers;

        // Constructor.
        public Course(string cName, int credits)
        {
            this.CourseName = cName;
            this.CourseCredits = credits;
            this.students = new ArrayList();
            this.teachers = new ArrayList();
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
