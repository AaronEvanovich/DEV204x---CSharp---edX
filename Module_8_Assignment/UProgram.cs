using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Description: Module Eight Assignment.
// Author: Javier Herrero Arnanz.

namespace Module_8_Assignment
{
    class UProgram
    {
        // UProgram variables and properties.
        public string ProgramName { get; set; }
        public string DepartmentHead { get; set; }
        public Degree Degree { get; set; }

        // Constructor.
        public UProgram(string pName, string departmentH, Degree degree)
        {
            this.ProgramName = pName;
            this.DepartmentHead = departmentH;
            this.Degree = degree;
        }
    }
}
