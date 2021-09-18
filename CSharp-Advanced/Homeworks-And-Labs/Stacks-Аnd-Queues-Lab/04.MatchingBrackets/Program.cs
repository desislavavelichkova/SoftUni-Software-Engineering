using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Stack<int> matchStack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == '(')
                {
                    matchStack.Push(i);
                }
                else if( ch == ')')
                {
                    int startIndex = matchStack.Pop();
                    string contents = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(contents);
                }
            }
            
        }
    }
}
