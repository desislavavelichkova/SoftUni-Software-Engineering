using System;
using System.Collections.Generic;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int freeWindowSeconds = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int totalCarsPassed = 0;
            Queue<string> cars = new Queue<string>();

            while (input != "END")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    int currGreenSeconds = greenLightSeconds;
                    while (cars.Count > 0)
                    {
                        string car = cars.Peek();

                        if (car.Length <= currGreenSeconds)
                        {
                            cars.Dequeue();
                            totalCarsPassed++;
                            currGreenSeconds -= car.Length;
                            if (currGreenSeconds == 0)
                            {
                                break;
                            }
                            
                        }
                        else if (car.Length <= currGreenSeconds + freeWindowSeconds)
                        {
                            cars.Dequeue();
                            totalCarsPassed++;
                            break;
                        }
                        else if (car.Length > currGreenSeconds + freeWindowSeconds)
                        {
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{car} was hit at {car[currGreenSeconds + freeWindowSeconds]}.");
                            Environment.Exit(0);
                        }

                    }

                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
        }
    }
}
