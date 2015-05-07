using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Description: Module Six Assignment.
// Author: Javier Herrero Arnanz.

namespace Module_6_Assignment
{
    class Teacher : Person
    {
        // Instances variables.
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
            Console.WriteLine("The teacher {0} is grading the test.",this.FirstName+" "+this.LastName);
        }

        public void PublishQualifications()
        {
            Console.WriteLine("The teacher {0} is publishing the Qualifications.", this.FirstName + " " + this.LastName);
        }

        public int TeachersInSchool()
        {
            return teachersCount;
        }
    }
}
