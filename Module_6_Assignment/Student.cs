using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Description: Module Six Assignment.
// Author: Javier Herrero Arnanz.

namespace Module_6_Assignment
{
    class Student : Person
    {
        // Instances variables.
        private static int studentsCount = 0;

        // Constructor.
        public Student(string fName, string lName, DateTime birthDate, string email)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.BirthDate = birthDate;
            this.Email = email;
            studentsCount++;
        }

        // Student methods.
        public void TakeTest()
        {
            Console.WriteLine("The student {0} is taking the test.", this.FirstName + " " + this.LastName);
        }

        public void CheckQualifications()
        {
            Console.WriteLine("The student {0} is checking the Qualifications.", this.FirstName + " " + this.LastName);
        }

        public int StudentsInSchool()
        {
            return studentsCount;
        }
    }
}
