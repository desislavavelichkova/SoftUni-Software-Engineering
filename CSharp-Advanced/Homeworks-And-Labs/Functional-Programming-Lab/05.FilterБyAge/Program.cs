using System;
using System.Collections.Generic;

namespace _05.FilterByAge
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Student[] student = new Student[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                student[i] = new Student();
                student[i].Name = input[0];
                student[i].Age = int.Parse(input[1]);

            }

            string condition = Console.ReadLine();
            int currentAge = int.Parse(Console.ReadLine());
            

            Func<Student, bool> filter = GetAgeCondition(condition, currentAge);
            Func<Student, string> formatter = GetFormatter(Console.ReadLine());

            PrintStudents(student, filter, formatter);

        }

        static Func<Student, bool> GetAgeCondition (string condition, int currentAge)
        {
            switch (condition)
            {
                case "younger": return x => x.Age < currentAge;
                case "older": return x => x.Age >= currentAge;
                default:
                    return null;
            }            
        }

        static Func<Student, string> GetFormatter(string format)
        {
            switch (format)
            {
                case "name":
                    return p => $"{p.Name}";
                case "age":
                    return p => $"{p.Age}";
                case "name age":
                    return p => $"{p.Name} - {p.Age}";
                default:
                    return null;
            }
        }
        private static void PrintStudents(Student[] students,
                                          Func<Student, bool> condition,
                                          Func<Student, string> formatter)
        {
            foreach (var student in students)
            {
                if (condition(student))
                {
                    Console.WriteLine(formatter(student));
                }
            }
        }

    }
}
