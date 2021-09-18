using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bombEffect = Console.ReadLine()
                                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();
            int[] bombCasing = Console.ReadLine()
                                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();
            Queue<int> effect = new Queue<int>(bombEffect);

            Stack<int> casing = new Stack<int>(bombCasing);

            int daturaBombs = 0;
            int cherryBombs = 0;
            int smokeDecoyBombs = 0;


            while (effect.Count != 0 && casing.Count != 0)
            {
                int effectValue = effect.Peek();
                int casingValue = casing.Peek();

                if (effectValue + casingValue == 40)
                {
                    daturaBombs++;
                    effect.Dequeue();
                    casing.Pop();
                    if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                    {
                        Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                        break;
                    }
                }
                else if (effectValue + casingValue == 60)
                {
                    cherryBombs++;
                    effect.Dequeue();
                    casing.Pop();

                    if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                    {
                        Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                        break;
                    }
                }
                else if (effectValue + casingValue == 120)
                {
                    smokeDecoyBombs++;
                    effect.Dequeue();
                    casing.Pop();
                    if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                    {
                        Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                        break;
                    }
                }
                else
                {
                    casingValue -= 5;
                    casing.Pop();
                    casing.Push(casingValue);
                }
                
            }
            if(daturaBombs < 3 || cherryBombs < 3 || smokeDecoyBombs < 3)
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (effect.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ",effect)}");
            }
            if (casing.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casing)}");
            }
            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {daturaBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
        }
    }
}
