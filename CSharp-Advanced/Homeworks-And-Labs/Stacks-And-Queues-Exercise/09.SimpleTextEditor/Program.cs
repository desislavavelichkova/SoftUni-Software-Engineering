using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {                
                string[] cmndArg = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int command = int.Parse(cmndArg[0]);

                if (command == 1)
                {
                    string newText = cmndArg[1];      
                    text += newText;

                    stack.Push(text);
                }
                else if (command == 2)
                {
                    int countElemnts = int.Parse(cmndArg[1]);
                    text = text.Substring(0, text.Length - countElemnts);
                    stack.Push(text);
                }
                else if (command == 3)
                {
                    int index = int.Parse(cmndArg[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (command == 4)
                {
                    stack.Pop();
                    if (stack.Count > 0)
                    {
                        text = stack.Peek();
                    }
                    else
                    {
                        text = string.Empty;
                    }
                }
            }
        }
    }
}
