using System;
using System.Linq;

namespace _2.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Func<string, int> parser = n => int.Parse(n);

            int[] array = input
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(parser)
                            .ToArray();
            
            int count = array.Length;
            int sum = array.Sum();
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    }
}
