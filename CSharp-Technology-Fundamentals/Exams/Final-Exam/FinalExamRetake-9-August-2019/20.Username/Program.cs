using System;

namespace _1.Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != "Sign up")
            {
                string[] cmndArgms = input.Split(" ");
                string command = cmndArgms[0];

                if (command == "Case")
                {
                    string secondCommand = cmndArgms[1];
                    if (secondCommand == "lower")
                    {
                        userName = userName.ToLower();
                    }
                    else if (secondCommand == "upper")
                    {
                        userName = userName.ToUpper();
                    }
                    Console.WriteLine(userName);
                }
                else if (command == "Reverse")
                {
                    int startIndex = int.Parse(cmndArgms[1]);
                    int endIndex = int.Parse(cmndArgms[2]);

                    if (startIndex >= 0 && startIndex < endIndex && endIndex < userName.Length)
                    {
                        string newSting = "";
                        for (int i = endIndex; i >= startIndex; i--)
                        {
                            newSting += userName[i];
                        }
                        Console.WriteLine(newSting);
                    }
                }
                else if (command == "Cut")
                {
                    string substring = cmndArgms[1];

                    if (userName.Contains(substring))
                    {
                        int index = userName.IndexOf(substring);
                        userName = userName.Remove(index, substring.Length);
                        Console.WriteLine(userName);
                    }
                    else
                    {
                        Console.WriteLine($"The word {userName} doesn't contain {substring}.");
                    }
                }
                else if (command == "Replace")
                {
                    string currentChar = cmndArgms[1];
                    userName = userName.Replace(currentChar, "*");
                    Console.WriteLine(userName);
                }
                else if (command == "Check")
                {
                    string charSymbol = cmndArgms[1];

                    if (userName.Contains(charSymbol))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {charSymbol}.");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
