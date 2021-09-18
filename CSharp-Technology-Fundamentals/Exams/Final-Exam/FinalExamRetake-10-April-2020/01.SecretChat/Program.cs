using System;
using System.Linq;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = Console.ReadLine();

            while (input  != "Reveal")
            {
                string[] cmnArgs = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string comand = cmnArgs[0];

                if (comand == "InsertSpace")
                {
                    int index = int.Parse(cmnArgs[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (comand == "Reverse")
                {
                    string substring = cmnArgs[1];

                    if (message.Contains(substring))
                    {
                        int index = message.IndexOf(substring);

                        string newSubstring = "";

                        message = message.Remove(index, substring.Length);

                        for (int i = substring.Length -1 ; i >= 0; i--)
                        {
                            newSubstring += substring[i];
                        }

                        message = message + newSubstring;
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (comand == "ChangeAll")
                {
                    string substring = cmnArgs[1];
                    string replacement = cmnArgs[2];

                    if (message.Contains(substring))
                    {
                        message = message.Replace(substring, replacement);
                        Console.WriteLine(message);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
