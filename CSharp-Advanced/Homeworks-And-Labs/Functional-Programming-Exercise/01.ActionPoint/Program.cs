using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            List< string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            names.ForEach(delegate (String name)
            {
                Console.WriteLine(name);
            });
        }
        
    }
}
