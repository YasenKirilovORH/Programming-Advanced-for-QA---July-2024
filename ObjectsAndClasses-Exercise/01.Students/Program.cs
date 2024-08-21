using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace _01.Students
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
           int numberOfStudents = int.Parse(Console.ReadLine());
            
            for (int count = 0; count < numberOfStudents; count++)
            {
                string[] input = Console.ReadLine().Split(" ");

                Student student = new Student(input[0], input[1], double.Parse(input[2]));

                students.Add(student);
            }

            foreach (Student student in students.OrderByDescending(s => s.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
    }

}

