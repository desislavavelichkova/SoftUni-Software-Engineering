using System;
using System.Collections.Generic;


namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length % 2 == 1)
            {
                Console.WriteLine("NO");
                return;
            }

            Stack<char> openParenthes = new Stack<char>();

            bool isBalanced = true;

            foreach (var item in input)
            {                          
                if (item == '(' || item == '[' || item == '{')
                {
                    openParenthes.Push(item);
                }
                else 
                {
                    bool isPairedFirst = (item == ')' && openParenthes.Pop() == '(');
                    bool isPairedSecond = (item == ']' && openParenthes.Pop() == '[');
                    bool isPairedThird = (item == '}' && openParenthes.Pop() == '{');
                    //bool isPairedFourth = (item == ' ' && openParenthes.Pop() == ' ');

                    if (!isPairedFirst && !isPairedSecond && !isPairedThird)
                    {
                        isBalanced = false;                       
                        break;
                    }
                }   
            }
            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
