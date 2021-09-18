using System;
using System.Collections.Generic;
using System.Linq;

namespace LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstList = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();
            Queue<int> firstLoot = new Queue<int>(firstList);

            int[] secondList = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToArray();
            Stack<int> secondLoot = new Stack<int>(secondList);
            int summedItem = 0;

            while (true)
            {
                int firstValue = firstLoot.Peek();
                int secondValue = secondLoot.Peek();

                int sum = firstValue + secondValue;

                if (sum % 2 == 0)
                {
                    summedItem += sum;
                    firstLoot.Dequeue();
                    secondLoot.Pop();
                }
                else
                {
                    firstLoot.Enqueue(secondValue);
                    secondLoot.Pop();
                }
                if (firstLoot.Count == 0)
                {
                    Console.WriteLine("First lootbox is empty");
                    break;
                }
                if (secondLoot.Count == 0)
                {
                    Console.WriteLine("Second lootbox is empty");
                    break;
                }
            }

            if (summedItem >= 100 )
            {
                Console.WriteLine($"Your loot was epic! Value: {summedItem}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {summedItem}");
            }
        }
    }
}
