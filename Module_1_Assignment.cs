using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Description: Module One Assignment.
// Author: Javier Herrero Arnanz.

namespace Module_1_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // STUDENT INFORMATION.
            string studFirstName;
            string studLastName;
            DateTime studBirthDate;
            string studAddressLine1;
            string studAddressLine2;
            string studCity;
            string studState;
            string studZip;
            string studCountry;
            string studEmail;

            studFirstName = "Javier";
            studLastName = "Herrero Arnanz";
            studBirthDate = new DateTime(1989, 2, 10);
            studAddressLine1 = "Long Street";
            studAddressLine2 = "Nº21 3ºC";
            studCity = "Valladolid";
            studState = "Valladolid";
            studZip = "47012B";
            studCountry = "Spain";
            studEmail = "javier@mail.com";

            Console.WriteLine("----------- STUDENT INFORMATION -----------");
            Console.WriteLine("studFirstName: " + studFirstName);
            Console.WriteLine("studLastName: " + studLastName);
            Console.WriteLine("studBirthDate: " + studBirthDate);
            Console.WriteLine("studAddressLine1: " + studAddressLine1);
            Console.WriteLine("studAddressLine2: " + studAddressLine2);
            Console.WriteLine("studCity: " + studCity);
            Console.WriteLine("studState: " + studState);
            Console.WriteLine("studZip: " + studZip);
            Console.WriteLine("studCountry: " + studCountry);
            Console.WriteLine("studEmail: " + studEmail);


            // PROFESSOR INFORMATION.
            string profFirstName;
            string profLastName;
            DateTime profBirthDate;
            string profAddressLine1;
            string profAddressLine2;
            string profCity;
            string profState;
            string profZip;
            string profCountry;
            string profEmail;

            profFirstName = "Manuel";
            profLastName = "Rodriguez Garcia";
            profBirthDate = new DateTime(1955, 4, 20); ;
            profAddressLine1 = "Short Street";
            profAddressLine2 = "Nº83 1ºB";
            profCity = "Paterna";
            profState = "Valencia";
            profZip = "46022A";
            profCountry = "Spain";
            profEmail = "manuel@mail.com";

            Console.WriteLine("----------- PROFESSOR INFORMATION -----------");
            Console.WriteLine("profFirstName: " + profFirstName);
            Console.WriteLine("profLastName: " + profLastName);
            Console.WriteLine("profBirthDate: " + profBirthDate);
            Console.WriteLine("profAddressLine1: " + profAddressLine1);
            Console.WriteLine("profAddressLine2: " + profAddressLine2);
            Console.WriteLine("profCity: " + profCity);
            Console.WriteLine("profState: " + profState);
            Console.WriteLine("profZip: " + profZip);
            Console.WriteLine("profCountry: " + profCountry);
            Console.WriteLine("profEmail: " + profEmail);


            // UNIVERSITY DEGREE.
            string degreeName;
            string school;
            int totalCredits;

            degreeName = "Bachelor's Degree in Computer Engineering";
            school = "School of Computer Sciences";
            totalCredits = 325;

            Console.WriteLine("----------- UNIVERSITY DEGREE -----------");
            Console.WriteLine("degreeName: " + degreeName);
            Console.WriteLine("school: " + school);
            Console.WriteLine("totalCredits: " + totalCredits);


            // UNIVERSITY PROGRAM.
            string programName;
            string degreesOffered;
            string departmentHead;

            programName = "Software Engineering";
            degreesOffered = "Bachelor, Master.";
            departmentHead = "Julian Lopez";

            Console.WriteLine("----------- UNIVERSITY PROGRAM -----------");
            Console.WriteLine("programName: " + programName);
            Console.WriteLine("degreesOffered: " + degreesOffered);
            Console.WriteLine("departmentHead: " + departmentHead);

            // COURSE.
            string courseDegree;
            string courseProgram;
            string courseName;
            int courseCredits;

            courseDegree = "Bachelor's Degree in Computer Engineering";
            courseProgram = "Software Engineering";
            courseName = "Graphic User Interfaces Development";
            courseCredits = 15;

            Console.WriteLine("----------- COURSE -----------");
            Console.WriteLine("degree: " + courseDegree);
            Console.WriteLine("program: " + courseProgram);
            Console.WriteLine("courseName: " + courseName);
            Console.WriteLine("courseCredits: " + courseCredits);


            // CHALLENGE.
            string userName;
            Console.WriteLine("Please insert your name:");
            userName = Console.ReadLine();
            Console.WriteLine("User name: " + userName);
        }
    }
}
