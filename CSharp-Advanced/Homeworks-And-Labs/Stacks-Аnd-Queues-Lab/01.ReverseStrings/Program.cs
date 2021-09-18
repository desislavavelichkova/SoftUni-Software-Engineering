using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reversedString = new Stack<char>();

            foreach (var ch in input)
            {
                reversedString.Push(ch);
            }
            while (reversedString.Count != 0)
            {
                Console.Write(reversedString.Pop());
            }
            Console.WriteLine();
        }
    }
}
