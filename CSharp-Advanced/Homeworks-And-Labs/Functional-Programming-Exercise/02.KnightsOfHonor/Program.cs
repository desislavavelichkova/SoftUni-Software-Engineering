using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

            names.ForEach(delegate (string name)
            {
                Console.WriteLine("Sir " + name);
            });
        }
    }
}
