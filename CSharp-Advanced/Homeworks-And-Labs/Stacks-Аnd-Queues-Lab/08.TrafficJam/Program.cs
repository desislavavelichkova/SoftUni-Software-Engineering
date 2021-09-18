using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPassedCars = int.Parse(Console.ReadLine());
            Queue<string> carsQueue = new Queue<string>();
            string input = Console.ReadLine();
            int carCount = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    if (carsQueue.Count <= nPassedCars)
                    {
                        nPassedCars = carsQueue.Count;
                    }
                    for (int i = 0; i < nPassedCars; i++)
                    {
                        carCount++;
                        string car = carsQueue.Dequeue();
                        Console.WriteLine($"{car} passed!");
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{carCount} cars passed the crossroads.");
        }
    }
}
