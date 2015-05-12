using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Description: Module Eight Assignment.
// Author: Javier Herrero Arnanz.

namespace Module_8_Assignment
{
    class Student : Person, IComparable
    {
        // Instances variable.
        private static int studentsCount = 0;

        // Student variables.
        private Stack<double> grades;

        // Constructor.
        public Student(string fName, string lName, DateTime birthDate, string email)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.BirthDate = birthDate;
            this.Email = email;
            this.grades = new Stack<double>();
            studentsCount++;
        }

        // Student methods.
        public void TakeTest()
        {
            Console.WriteLine("The student {0} is taking the test.", this.FirstName + " " + this.LastName);
        }

        public void addGrade(double grade)
        {
            grades.Push(grade);
        }

        public double popGrade()
        {
            return grades.Pop();
        }

        public void showGrades()
        {
            string grades = "";
            foreach (double grade in this.grades)
            {
                grades += grade.ToString() + " ";
            }
            Console.WriteLine("Grades: {0}", grades);
        }

        public int StudentsInSchool()
        {
            return studentsCount;
        }

        public int CompareTo(object obj)
        {
            Student studentC = (Student)obj;
            string nameC = studentC.FirstName + " " + studentC.LastName;
            string name = this.FirstName + " " + this.LastName;
            return (name.CompareTo(nameC));
        }
    }
}
