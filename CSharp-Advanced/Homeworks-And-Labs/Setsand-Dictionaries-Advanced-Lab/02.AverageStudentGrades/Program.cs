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
            Dictionary<string, List<decimal>> information = new Dictionary<string, List<decimal>>();


            for (int i = 0; i < studentsCount; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!information.ContainsKey(name))
                {
                    information.Add(name, new List<decimal>());
                    information[name].Add(grade);
                }
                else
                {
                    information[name].Add(grade);
                }
            }

            foreach (var student in information)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value)} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
