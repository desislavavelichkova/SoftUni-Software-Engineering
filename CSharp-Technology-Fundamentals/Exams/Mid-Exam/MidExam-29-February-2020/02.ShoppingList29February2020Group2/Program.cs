using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList29February2020Group2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> grocery = Console.ReadLine()
                             .Split("!", StringSplitOptions.RemoveEmptyEntries)
                             .ToList();
                          

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] cmnd = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmnd[0];
                string product = cmnd[1];
                

                if (command == "Urgent")
                {
                    if (!grocery.Contains(product))
                    {
                        grocery.Insert(0, product);
                    }
                }
                else if (command == "Unnecessary")
                {
                    if (grocery.Contains(product))
                    {
                        grocery.Remove(product);
                    }
                }
                else if (command == "Correct")
                {
                    string newItem = cmnd[2];

                    if (grocery.Contains(product))
                    {
                       int index = grocery.FindIndex(x => x == product); // намира индекс на елемент
                       grocery[index] = newItem;                        
                        
                    }
                }
                else if (command == "Rearrange")
                {
                    if (grocery.Contains(product))
                    {
                        grocery.Remove(product);
                        grocery.Add(product);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",grocery));
        }
    }
}
