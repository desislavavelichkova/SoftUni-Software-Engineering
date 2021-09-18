using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wordrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                                .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];                

                if (!wordrobe.ContainsKey(color))
                {
                    wordrobe.Add(color, new Dictionary<string, int>());
                }

                string[] clothes = input[1]
                                    .Split(",", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wordrobe[color].ContainsKey(clothes[j]))
                    {
                        wordrobe[color].Add(clothes[j], 1);
                    }
                    else
                    {
                        wordrobe[color][clothes[j]]++;
                    }
                }
            }

            string[] findClothes = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string searchedColor = findClothes[0];
            string searchedClothes = findClothes[1];
                      

            foreach (var color in wordrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var cloth in wordrobe[color.Key])
                {
                    if (color.Key == searchedColor && cloth.Key == searchedClothes)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                    
                }
            }
        }
    }
}
