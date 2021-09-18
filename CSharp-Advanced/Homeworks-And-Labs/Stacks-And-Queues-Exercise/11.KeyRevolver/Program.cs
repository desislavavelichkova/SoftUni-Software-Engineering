using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            Stack<int> bullet = new Stack<int>(bullets);

            int[] locks = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            

            int intelligence = int.Parse(Console.ReadLine());

            Queue<int> lockNumbers = new Queue<int>(locks);
            int barrelsCount = 0;
            int countBullets = 0;
            while (lockNumbers.Count > 0 && bullet.Count > 0)
            {
                if (lockNumbers.Peek() >= bullet.Peek())
                {
                    Console.WriteLine("Bang!");
                    lockNumbers.Dequeue();
                    bullet.Pop();
                    countBullets++;
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bullet.Pop();
                    countBullets++;
                }

                barrelsCount++;

                if (sizeOfGunBarrel == barrelsCount && bullet.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    barrelsCount = 0;
                    
                }
            }


            if (bullet.Count == 0 && lockNumbers.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {lockNumbers.Count}");
            }
            else if (lockNumbers.Count == 0 && bullet.Count >= 0)
            {
                Console.WriteLine($"{bullet.Count} bullets left. Earned ${intelligence - (countBullets*bulletPrice)}");
            }
        }
    }
}
