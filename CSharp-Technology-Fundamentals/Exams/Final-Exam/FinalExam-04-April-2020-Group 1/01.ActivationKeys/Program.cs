using System;
using System.Linq;

namespace _01.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activarionKey = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] cmndArgs = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string command = cmndArgs[0];

                if (command == "Contains")
                {
                    string substring = cmndArgs[1];
                    if (activarionKey.IndexOf(substring) != -1)
                    {
                        Console.WriteLine($"{activarionKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string secondCommand = cmndArgs[1];
                    int startIndex = int.Parse(cmndArgs[2]);
                    int endIndex = int.Parse(cmndArgs[3]);

                    string firstPart = activarionKey.Substring(0, startIndex);
                    string secondPart = activarionKey.Substring(startIndex, endIndex - startIndex);
                    string thirdPart = activarionKey.Substring(endIndex);

                    if (secondCommand == "Upper")
                    {
                        secondPart = secondPart.ToUpper();
                    }
                    else
                    {
                        secondPart = secondPart.ToLower();                        
                    }

                    activarionKey = firstPart + secondPart + thirdPart;
                    Console.WriteLine(activarionKey);
                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(cmndArgs[1]);
                    int entIndex = int.Parse(cmndArgs[2]);

                    activarionKey = activarionKey.Remove(startIndex, entIndex - startIndex);

                    Console.WriteLine(activarionKey);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {activarionKey}");
        }
    }
}
