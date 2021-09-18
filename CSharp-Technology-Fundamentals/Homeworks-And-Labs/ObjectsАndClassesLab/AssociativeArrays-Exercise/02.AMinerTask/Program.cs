using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> resource = new Dictionary<string, List<int>>();
            

            string material = Console.ReadLine();

            while (material != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resource.ContainsKey(material) == false)
                {
                    resource.Add(material, new List<int> { quantity });
                }
                else
                {
                    resource[material].Add(quantity);
                }

                material = Console.ReadLine();
            }

            foreach (var item in resource)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value.Sum())}");
            }
        }
    }
}
