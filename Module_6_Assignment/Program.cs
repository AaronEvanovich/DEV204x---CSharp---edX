using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Description: Module Six Assignment.
// Author: Javier Herrero Arnanz.

namespace Module_6_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- Instantiate three Student objects.
            Student student1 = new Student("John", "Snow", new DateTime(1990, 10, 22), "john@mail.com");
            Student student2 = new Student("Tyrion", "Lanyster", new DateTime(1950, 03, 12), "tyrion@mail.com");
            Student student3 = new Student("Jessie", "Pinkman", new DateTime(1985, 04, 03), "jessie@mail.com");

            // 2- Instantiate a Course object called Programming with C#.
            Course course = new Course("Programming with C#", 15);

            // 3- Add your three students to this Course object.
            course.addStudent(student1);
            course.addStudent(student2);
            course.addStudent(student3);

            // 4- Instantiate at least one Teacher object.
            Teacher teacher = new Teacher("Walter", "White", new DateTime(1975, 12, 27), "walter@mail.com");
            
            // 5- Add that Teacher object to your Course object.
            course.addTeacher(teacher);

            // 6- Instantiate a Degree object, such as Bachelor.
            Degree degree = new Degree("Bachelor of Science", 250, null);

            // 7- Add your Course object to the Degree object.
            degree.Course = course;

            // 8- Instantiate a UProgram object called Information Technology.
            UProgram uProgram = new UProgram("Information Technology", "Gustavo Fring", null);

            // 9- Add the Degree object to the UProgram object.
            uProgram.Degree = degree;

            // 10- Output the information.
            Console.WriteLine("The {0} program contains the {1} degree\n", uProgram.ProgramName, uProgram.Degree.DegreeName);
            Console.WriteLine("The {0} degree contains the course {1}\n", uProgram.Degree.DegreeName, uProgram.Degree.Course.CourseName);
            Console.WriteLine("The {0} course contains {1} student(s)\n", uProgram.Degree.Course.CourseName, uProgram.Degree.Course.StudentsNumber);

            // CHALLENGE. Polymorphism.
            Person person1 = new Person();
            Student student4 = new Student("Peter", "Smith", new DateTime(1975, 02, 01), "peter@mail.com");
            person1 = student4;
            Console.WriteLine("{0}, {1}, {2}", person1.FirstName + " " + person1.LastName, person1.BirthDate, person1.Email);
        }
    }
}
