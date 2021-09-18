using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rosesArray = Console.ReadLine()
                                .Split(", ")
                                .Select(int.Parse)
                                .ToArray();
            Queue<int> roses = new Queue<int>(rosesArray);
            int[] liliesArray = Console.ReadLine()
                                .Split(", ")
                                .Select(int.Parse)
                                .ToArray();
            Stack<int> lilies = new Stack<int>(liliesArray);

            int flowerWreaths = 0;
            int sumFlowers = 0;

            while (lilies.Count != 0 && roses.Count != 0)
            {
               
                int rosesValue = roses.Peek();
                int liliesValue = lilies.Peek();

                if (rosesValue + liliesValue == 15)
                {
                    roses.Dequeue();
                    lilies.Pop();
                    flowerWreaths++;
                    if (flowerWreaths == 5)
                    {
                        break;
                    }
                }
                else if (rosesValue + liliesValue < 15)
                {
                    sumFlowers += rosesValue + liliesValue;
                    roses.Dequeue();
                    lilies.Pop();
                }
                else if (rosesValue + liliesValue > 15)
                {
                    liliesValue = lilies.Pop() - 2;
                    lilies.Push(liliesValue);
                }
            }
            if (flowerWreaths == 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {flowerWreaths} wreaths!");
            }

            else if(flowerWreaths < 5)
            {
                if (sumFlowers >= 15)
                {                    
                    flowerWreaths += (sumFlowers / 15);
                }
                if (flowerWreaths >=5)
                {
                    Console.WriteLine($"You made it, you are going to the competition with {flowerWreaths} wreaths!");
                }
                else
                {
                    Console.WriteLine($"You didn't make it, you need {5 - flowerWreaths} wreaths more!");
                }

            }           
            
        }
    }
}
