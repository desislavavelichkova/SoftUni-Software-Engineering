using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collection = Console.ReadLine()
                                      .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                      .ToList();


            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                string[] cmndArg = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmndArg[0];
                string item = cmndArg[1];
                


                if (command == "Collect")
                {
                    if (!collection.Contains(item))
                    {
                        collection.Add(item);                                     
                    }                    
                }
                if (command == "Drop")
                {
                    if (collection.Contains(item))
                    {
                        collection.Remove(item);
                    }
                    
                }
                if (command == "Renew")
                {
                    if (collection.Contains(item))
                    {
                        collection.Remove(item);
                        collection.Add(item);
                    }                    
                }
                if (command == "Combine Items")
                {
                    string[] cmndArg2 = item.Split(":", StringSplitOptions.RemoveEmptyEntries);
                    string oldItem = cmndArg2[0];
                    string newItem = cmndArg2[1];

                    if (collection.Contains(oldItem))
                    {
                        int index = collection.FindIndex(x => x == oldItem);
                        collection.Insert(index+1, newItem);
                    }
                }

                input = Console.ReadLine();
            }

            
                Console.WriteLine(string.Join(", ", collection));
         
        }
       
    }
}
