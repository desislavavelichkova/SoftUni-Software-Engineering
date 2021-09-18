using System;
using System.Collections.Generic;
using System.Linq;

namespace SantasPresentFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] materialData = Console.ReadLine()
                                .Split(" ");

            string[] magicData = Console.ReadLine().Split(" ");

            Stack<string> matrials = new Stack<string>(materialData);
            Queue<string> magicLevel = new Queue<string>(magicData);


            Dictionary<string, int> precents = new Dictionary<string, int>();
            precents.Add("Doll", 0);
            precents.Add("Wooden train", 0);
            precents.Add("Teddy bear", 0);
            precents.Add("Bicycle", 0);
        

        int doll = 150;
            int train = 250;
            int bear = 300;
            int bicycle = 400;

            while (matrials.Count != 0 || magicLevel.Count != 0) 
            {
                if (matrials.Count == 0)
                {
                    break;
                }
                if (magicLevel.Count == 0)
                {
                    break; 
                }
                int material = int.Parse(matrials.Peek());
                int magic = int.Parse(magicLevel.Peek());

                if (material == 0)
                {
                    matrials.Pop();
                    continue;
                }
                else if (magic == 0)
                {
                    magicLevel.Dequeue();
                    continue;
                }

                int multiplication = material * magic;

                if (material * magic == doll)
                {
                    matrials.Pop();
                    magicLevel.Dequeue();
                    precents["Doll"]++;

                }
                else if (material * magic == train)
                {
                    matrials.Pop();
                    magicLevel.Dequeue();
                    precents["Wooden train"]++;
                }
                else if (material * magic == bear)
                {
                    matrials.Pop();
                    magicLevel.Dequeue();
                    precents["Teddy bear"]++;
                }

                else if (material * magic == bicycle)
                {
                    matrials.Pop();
                    magicLevel.Dequeue();
                    precents["Bicycle"]++;

                }
                else if (material * magic < 0)
                {
                    magicLevel.Dequeue();
                    matrials.Pop();
                    matrials.Push((material + magic).ToString());
                }
                else if (material * magic > 0 &&
                         multiplication != doll &&
                         multiplication != train &&
                         multiplication != bear &&
                         multiplication != bicycle)
                {
                    magicLevel.Dequeue();
                    matrials.Pop();
                    matrials.Push((material + 15).ToString());
                }                
            }
            if (precents["Doll"] > 0  && precents["Wooden train"] > 0)
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else if (precents["Teddy bear"] > 0 && precents["Bicycle"] > 0)
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }
            
            if (matrials.Count > 0)
            {
                Console.WriteLine($"Materials left: {string.Join(", ",matrials)}");
            }
            if (magicLevel.Count > 0)
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magicLevel)}");
            }


            foreach (var toy in precents.OrderBy(x => x.Key))
            {
                if (toy.Value > 0 )
                {
                    Console.WriteLine($"{toy.Key}: {toy.Value}");
                }
            }          
        }
    }
}
