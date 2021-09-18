using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Stack<string> numberStack = new Stack<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                numberStack.Push(input[i]);
            }

            while (numberStack.Count > 1)
            {
                int firstNumber = int.Parse(numberStack.Pop());
                string symbol = numberStack.Pop();
                int secondNumber = int.Parse(numberStack.Pop());

                if (symbol == "+")
                {
                    numberStack.Push((firstNumber + secondNumber).ToString());
                }
                else if (symbol == "-")
                {
                    numberStack.Push((firstNumber - secondNumber).ToString());
                }
            }
            
            Console.WriteLine(numberStack.Peek());
        }
    }
}
