using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsInformation = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentsInformation.ContainsKey(name) == false)
                {
                    studentsInformation.Add(name, new List<double> { grade });
                }
                else
                {
                    studentsInformation[name].Add(grade);
                }
            }

            foreach (var student in studentsInformation.OrderByDescending(x => x.Value.Average()))
            {
                double averageGrade = student.Value.Average();

                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {averageGrade:f2}");
                }
            }
        }
    }
}
