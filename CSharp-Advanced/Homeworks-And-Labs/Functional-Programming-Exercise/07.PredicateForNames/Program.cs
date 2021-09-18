using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)                                
                                .ToList();
                       
            Predicate<int> predicate = x => x <= nameLength;

            Console.WriteLine(string.Join(Environment.NewLine, MyWhere(names, predicate)));

        }
        static List<string> MyWhere(List<string> names, Predicate<int> predicate)
        {
            List<string> newNames = new List<string>();

            foreach (var currName in names)
            {
                if (predicate(currName.Length))
                {
                    newNames.Add(currName);
                }
            }
            return newNames;
        }    
    }
}
