using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterial = new Dictionary<string, int>();

            keyMaterials["motes"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["shards"] = 0;
            bool hasToBreak = false;

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < input.Length; i+=2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    if (material == "motes" || material == "fragments" || material == "shards")
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;

                            if (material == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            else if (material == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else if (material == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }

                            hasToBreak = true;
                            break;
                        }
                    }
                    else
                    {
                        if (junkMaterial.ContainsKey(material) == false)
                        {
                            junkMaterial.Add(material, 0);
                        }
                        junkMaterial[material] += quantity;
                    }                   
                }
                if (hasToBreak)
                {
                    break;
                }
            }

            Dictionary<string, int> filteredKeyMaterials = keyMaterials
                .OrderByDescending(v => v.Value)
                .ThenBy(k => k.Key)
                .ToDictionary(a => a.Key, a => a.Value);

            foreach (var item in filteredKeyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkMaterial.OrderBy(k => k.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
