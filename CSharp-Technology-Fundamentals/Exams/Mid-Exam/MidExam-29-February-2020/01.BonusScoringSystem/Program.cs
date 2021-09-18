using System;

namespace _01.BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int courseLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            double bestBonus = 0;
            int bestStudentAttendances = 0;


            for (int i = 0; i < students; i++)
            {
                int studentAttendances = int.Parse(Console.ReadLine());
                double totalBonus = (studentAttendances*1.0 / courseLectures * (5 + additionalBonus));
                if (totalBonus > bestBonus)
                {
                    bestBonus = totalBonus;
                    bestStudentAttendances = studentAttendances;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(bestBonus)}.");
            Console.WriteLine($"The student has attended {bestStudentAttendances} lectures.");

        }
    }
}
