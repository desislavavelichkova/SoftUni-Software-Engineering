using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] countOfClothes = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            int sum = 0;
            Stack<int> clothes = new Stack<int>(countOfClothes);

            int racks = 1;

            while (clothes.Count > 0)
            {
                int currClothes = clothes.Pop();
                sum += currClothes;

                if (sum > rackCapacity)
                {
                    racks++;
                    clothes.Push(currClothes);
                    sum = 0;
                }
                else if (sum < rackCapacity)
                {                    
                    continue;
                }
                else if(sum == rackCapacity && clothes.Count > 0)
                {
                    racks++;
                    sum = 0;                    
                }                              
                
            }
            Console.WriteLine(racks);
        }
    }
}
