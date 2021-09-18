using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();
                       
            while (input != "end")
            {
                string[] command = input.Split(" ");

                string firstName = command[0];
                string lastName = command[1];
                int age = int.Parse(command[2]);
                string town = command[3];

                Student student = students.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
                
                if (student == null)
                {
                    students.Add(new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = town
                    });
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Hometown = town;
                }
                           
                    input = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.Hometown == filterCity)
                {                    
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }        
        
    }
   
}
