using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Description: Module Eight Assignment.
// Author: Javier Herrero Arnanz.

namespace Module_8_Assignment
{
    class Teacher : Person, IComparable
    {
        // Instances variable.
        private static int teachersCount = 0;

        // Constructor.
        public Teacher(string fName, string lName, DateTime birthDate, string email)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.BirthDate = birthDate;
            this.Email = email;
            teachersCount++;
        }

        // Teacher methods.
        public void GradeTest()
        {
            Console.WriteLine("The teacher {0} is grading the test.", this.FirstName + " " + this.LastName);
        }

        public int TeachersInSchool()
        {
            return teachersCount;
        }

        public int CompareTo(object obj)
        {
            Teacher teacherC = (Teacher)obj;
            string nameC = teacherC.FirstName + " " + teacherC.LastName;
            string name = this.FirstName + " " + this.LastName;
            return (name.CompareTo(nameC));
        }
    }
}
