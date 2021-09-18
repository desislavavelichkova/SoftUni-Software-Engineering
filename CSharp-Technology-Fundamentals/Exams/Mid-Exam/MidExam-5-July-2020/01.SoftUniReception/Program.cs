using System;

namespace _01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int totalStudentsPerHour = first + second + third;
            int students = int.Parse(Console.ReadLine());
            int hour = 0;

            while(students > 0)
            {
                hour++;
                students -= totalStudentsPerHour;

                if (hour % 4 == 0)
                {
                    hour++;
                }
            }

            Console.WriteLine($"Time needed: {hour}h.");
        }
    }
}
