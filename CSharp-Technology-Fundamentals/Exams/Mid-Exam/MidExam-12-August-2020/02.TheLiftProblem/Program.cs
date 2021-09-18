using System;
using System.Linq;

namespace _02.TheLiftProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int[] wagons = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int maxPeopleInWagone = 4;
            int diff = 0;
            int emptySports = 0;

            for (int i = 0; i < wagons.Length; i++)
            {

                diff = maxPeopleInWagone - wagons[i];

                if (people <= diff)
                {
                    wagons[i] += people;
                    people = 0;
                }
                else
                {
                    wagons[i] += diff;
                    people -= diff;                    
                }
                emptySports += maxPeopleInWagone - wagons[i];

            }
            if (people == 0 && emptySports > 0 )
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else if (people > 0 && emptySports == 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }

            else if (people == 0 && emptySports == 0)
            {
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
}
