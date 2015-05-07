using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Description: Module Six Assignment.
// Author: Javier Herrero Arnanz.

namespace Module_6_Assignment
{
    class Degree
    {
        // Degree variables and properties.
        public string DegreeName { get; set; }
        public int TotalCredits { get; set; }
        public Course Course { get; set; }

        // Constructor.
        public Degree(string dName, int credits, Course course)
        {
            this.DegreeName = dName;
            this.TotalCredits = credits;
            this.Course = course;
        }
    }
}
