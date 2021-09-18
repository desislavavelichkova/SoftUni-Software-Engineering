using System;

namespace _01.NationalCourt29February2020Group2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int totalPeople = int.Parse(Console.ReadLine());

            int totalPeoplePerHour = first + second + third;

            int hours = 0;

            while (totalPeople > 0)
            {
                totalPeople -= totalPeoplePerHour;
                hours++;

                if (hours % 4 == 0)
                {
                    hours++;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
