using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

            string[] input = Console.ReadLine()
                            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                            .Where(checker)
                            .ToArray();

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }


        }
    }
}
