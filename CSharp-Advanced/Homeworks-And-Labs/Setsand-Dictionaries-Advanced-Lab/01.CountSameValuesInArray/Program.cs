using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();


            for (int i = 0; i < studentsCount; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<decimal>());
                    students[name].Add(grade);
                }
                else
                {
                    students[name].Add(grade);
                }
            }
            foreach (var student in students)
            {
                Console.Write($"{student.Key} -> {string.Join(" ", student.Value)} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
