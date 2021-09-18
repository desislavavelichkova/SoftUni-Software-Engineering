using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();

            stack.AddRange(new List<string>()
            {
                "abc",
                "dgh",
                "gdhdjk",
                "gddhsh"
            });

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }

}
