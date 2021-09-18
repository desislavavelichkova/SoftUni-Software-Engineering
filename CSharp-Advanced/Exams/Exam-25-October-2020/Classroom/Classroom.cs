using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classroom
{
    public class Classroom
    {

        private List<Student> students;
                
        public int Count
        {
            get => students.Count;
        }
        public Classroom(int capacity)
        {
            Capacity = capacity;
            students = new List<Student>();            
        }

        public int Capacity { get;}


        public string RegisterStudent(Student student)
        {
            if (students.Count < Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return $"No seats in the classroom";
            }
        }
        public string DismissStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault(x => x.FirstName == firstName);

            if (student == null)
            {
                return "Student not found";
            }
            else
            {                
                students.Remove(student);
                return $"Dismissed student {firstName} {lastName}";
            }
        }
        public string GetSubjectInfo(string subject)
        {
            if (!students.Where(x => x.Subject == subject).Any())
            {
                return "No students enrolled for the subject";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"Subject: {subject}\n");
                sb.Append("Students:\n");

                foreach (var item in students.Where(x => x.Subject == subject))
                {
                    sb.Append($"{item.FirstName} {item.LastName}\n");
                }
                return sb.ToString();
            }
        }

        public int GetStudentsCount()
        {
            return students.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return student;
                }
            }
            return null;
        }
    
    }
}
