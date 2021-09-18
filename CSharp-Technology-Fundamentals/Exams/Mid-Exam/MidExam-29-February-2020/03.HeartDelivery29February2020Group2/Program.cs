using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03.HeartDelivery29February2020Group2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine()
                                 .Split("@", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
                        
            int jumpedPosition = 0;
            string input = Console.ReadLine();


            while (input != "Love!")
            {
                string[] cmndArg = input
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int jumpLenght = int.Parse(cmndArg[1]);
                jumpedPosition += jumpLenght;

                if (jumpedPosition >= 0 && jumpedPosition < neighborhood.Length)
                {
                    neighborhood[jumpedPosition] -= 2;
                }
                else
                {
                    jumpedPosition = 0;
                    neighborhood[jumpedPosition] -= 2;
                }

                if (neighborhood[jumpedPosition] == 0)
                {
                    Console.WriteLine($"Place {jumpedPosition} has Valentine's day.");
                }

                else if (neighborhood[jumpedPosition] < 0)
                {
                    Console.WriteLine($"Place {jumpedPosition} already had Valentine's day.");
                }
                                
                input = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {jumpedPosition}.");
            
            int failCount = neighborhood.Count(x => x > 0);

            if (failCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failCount} places.");
            }
           
        }
    }
}
