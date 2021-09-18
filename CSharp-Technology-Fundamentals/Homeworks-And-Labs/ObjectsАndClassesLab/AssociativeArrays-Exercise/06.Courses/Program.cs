using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int studentCounter = 0;

            List<string> studentsName = new List<string>();

            Dictionary<string, List<string>> coursInformation = new Dictionary<string, List<string>>();

            while (input != "end")
            {
                string[] cmndArg = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string courseName = cmndArg[0];
                string studentName = cmndArg[1];

                if (coursInformation.ContainsKey(courseName) == false)
                {
                    coursInformation.Add(courseName, new List<string> { studentName });
                    studentCounter = 1;
                }
                else
                {
                    coursInformation[courseName].Add(studentName);
                    studentCounter++;
                }
                input = Console.ReadLine();
            }

            foreach (var course in coursInformation.OrderByDescending(x => x.Value.Count))
            {
                int counter = coursInformation[course.Key].Count();    
                Console.WriteLine($"{course.Key}: {counter}");

                foreach (var students in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {students}");
                }
            }   
        }
    }
}
