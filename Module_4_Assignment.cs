using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Description: Module Four Assignment.
// Author: Javier Herrero Arnanz.

namespace Module_4_Assignment
{
    class ConsoleProgram
    {
        public struct Student
        {
            // Student variables.
            public string studFirstName;
            public string studLastName;
            public DateTime studBirthDate;
            public string studAddress;
            public string studCity;
            public string studState;
            public string studZip;
            public string studCountry;
            public string studEmail;

            // Student constructor.
            public Student(string fName, string lName, DateTime birthday, string address, string city, string state, string zip, string country, string email)
            {
                this.studFirstName = fName;
                this.studLastName = lName;
                this.studBirthDate = birthday;
                this.studAddress = address;
                this.studCity = city;
                this.studState = state;
                this.studZip = zip;
                this.studCountry = country;
                this.studEmail = email;
            }
        }

        public struct Teacher
        {
            // Teacher variables.
            public string profFirstName;
            public string profLastName;
            public DateTime profBirthDate;
            public string profAddress;
            public string profCity;
            public string profState;
            public string profZip;
            public string profCountry;
            public string profEmail;

            // Teacher constructor.
            public Teacher(string fName, string lName, DateTime birthday, string address, string city, string state, string zip, string country, string email)
            {
                this.profFirstName = fName;
                this.profLastName = lName;
                this.profBirthDate = birthday;
                this.profAddress = address;
                this.profCity = city;
                this.profState = state;
                this.profZip = zip;
                this.profCountry = country;
                this.profEmail = email;
            }
        }

        public struct Program
        {
            // Program variables.
            public string programName;
            public string degreeName;
            public string departmentHead;

            // Program constructor.
            public Program(string program, string degree, string departmentH)
            {
                this.programName = program;
                this.degreeName = degree;
                this.departmentHead = departmentH;
            }
        }

        public struct Course
        {
            // Course variables.
            public string courseName;
            public string programName;
            public int courseCredits;

            // Course constructor.
            public Course(string name, string program, int credits)
            {
                this.courseName = name;
                this.programName = program;
                this.courseCredits = credits;
            }
        }

        static void Main(string[] args)
        {
            // Array of students.
            Student[] students = new Student[5];

            // Fill one student.
            Student student = new Student("Manuel", "Rodriguez Garcia", new DateTime(1955, 4, 20), "Short Street Nº83 1ºB", "Paterna", "Valencia", "46022A", "Spain", "manuel@mail.com");
            students[0] = student;

            // Print student info.
            Console.WriteLine("\n----------- STUDENT INFORMATION -----------");
            Console.WriteLine("studFirstName: " + students[0].studFirstName);
            Console.WriteLine("studLastName: " + students[0].studLastName);
            Console.WriteLine("studBirthDate: " + students[0].studBirthDate);
            Console.WriteLine("studAddress: " + students[0].studAddress);
            Console.WriteLine("studCity: " + students[0].studCity);
            Console.WriteLine("studState: " + students[0].studState);
            Console.WriteLine("studZip: " + students[0].studZip);
            Console.WriteLine("studCountry: " + students[0].studCountry);
            Console.WriteLine("studEmail: " + students[0].studEmail);

            // CHALLENGE.
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("\n----------- ENTER DATA FOR STUDENT {0} -----------", i);
                Console.WriteLine("Enter the student's first name: ");
                students[i].studFirstName = Console.ReadLine();
                Console.WriteLine("Enter the student's last name: ");
                students[i].studLastName = Console.ReadLine();
                Console.WriteLine("Enter the student's birthday (dd/mm/aaaa): ");
                students[i].studBirthDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter the student's address: ");
                students[i].studAddress = Console.ReadLine();
                Console.WriteLine("Enter the student's city: ");
                students[i].studCity = Console.ReadLine();
                Console.WriteLine("Enter the student's state: ");
                students[i].studState = Console.ReadLine();
                Console.WriteLine("Enter the student's zip: ");
                students[i].studZip = Console.ReadLine();
                Console.WriteLine("Enter the student's country: ");
                students[i].studCountry = Console.ReadLine();
                Console.WriteLine("Enter the student's email: ");
                students[i].studEmail = Console.ReadLine();
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("\n----------- STUDENT {0} INFORMATION -----------",i);
                Console.WriteLine("studFirstName: " + students[i].studFirstName);
                Console.WriteLine("studLastName: " + students[i].studLastName);
                Console.WriteLine("studBirthDate: " + students[i].studBirthDate);
                Console.WriteLine("studAddress: " + students[i].studAddress);
                Console.WriteLine("studCity: " + students[i].studCity);
                Console.WriteLine("studState: " + students[i].studState);
                Console.WriteLine("studZip: " + students[i].studZip);
                Console.WriteLine("studCountry: " + students[i].studCountry);
                Console.WriteLine("studEmail: " + students[i].studEmail);
            }
        }
    }
}
