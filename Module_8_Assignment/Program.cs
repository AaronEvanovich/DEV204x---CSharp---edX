using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Description: Module Eight Assignment.
// Author: Javier Herrero Arnanz.

namespace Module_8_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- Instantiate three Student objects.
            Student student1 = new Student("John", "Snow", new DateTime(1990, 10, 22), "john@mail.com");
            Student student2 = new Student("Tyrion", "Lannister", new DateTime(1950, 03, 12), "tyrion@mail.com");
            Student student3 = new Student("Robb", "Stark", new DateTime(1985, 04, 03), "robb@mail.com");
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            // 2- Add 5 grades to the Stack in each Student object.
            foreach (Student s in students)
            {
                for (int i = 0; i < 5; i++)
                {
                    double grade = i + 5;
                    s.addGrade(grade);
                }
            }

            // 3- Remove the last entered grade and replace it with a new one.
            foreach (Student s in students)
            {
                s.popGrade();
                s.addGrade(10);
            }

            // 4- Instantiate a Course object called Programming with C#.
            Course course = new Course("Programming with C#", 15);

            // 5- Add your three students to this Course object.
            course.addStudent(student1);
            course.addStudent(student2);
            course.addStudent(student3);

            // 6- Output the name of the students.
            course.listStudents();
        }
    }
}
