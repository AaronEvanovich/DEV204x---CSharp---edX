using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Description: Module Six Assignment.
// Author: Javier Herrero Arnanz.

namespace Module_6_Assignment
{
    class Course
    {
        // Constants.
        private static int maxStudents = 3;
        private static int maxTeachers = 3;

        // Course variables and properties.
        public string CourseName { get; set; }
        public int CourseCredits { get; set; }
        private Student[] students;
        private Teacher[] teachers;
        private int studentsNumber;
        private int teachersNumber;

        public int StudentsNumber
        {
            get { return this.studentsNumber; }
        }

        public int TeachersNumber
        {
            get { return this.teachersNumber; }
        }

        // Constructor.
        public Course(string cName, int credits)
        {
            this.CourseName = cName;
            this.CourseCredits = credits;
            this.students = new Student[maxStudents];
            this.studentsNumber = 0;
            this.teachers = new Teacher[maxTeachers];
            this.teachersNumber = 0;
        }

        // Method to add a student.
        public void addStudent(Student student)
        {
            int n = this.StudentsNumber;
            if (n < maxStudents)
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
            if (n < maxTeachers)
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
