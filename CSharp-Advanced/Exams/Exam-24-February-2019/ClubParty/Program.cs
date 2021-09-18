using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCapacity = int.Parse(Console.ReadLine());
            var inputLine = Console.ReadLine().Split();

            Stack<string> elements = new Stack<string>(inputLine);
            Queue<string> halls = new Queue<string>();
            List<int> reservations = new List<int>();

            int currentCapacity = 0;

            while (elements.Count > 0)
            {
                string currentElemet = elements.Pop();

                bool isNumber = int.TryParse(currentElemet, out int parsedNumber);

                if (!isNumber)
                {
                    halls.Enqueue(currentElemet);
                }

                else
                {
                    if (halls.Count == 0)
                    {
                        continue;
                    }

                    if (currentCapacity + parsedNumber > maxCapacity)
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", reservations)}");
                        reservations.Clear();
                        currentCapacity = 0;
                    }

                    if (halls.Count > 0)
                    {
                        reservations.Add(parsedNumber);
                        currentCapacity += parsedNumber;

                    }
                }

            }
        }
    }
}
