using System;

namespace _01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Travel")
            {
                string[] cmndArgms = input.Split(":");

                string command = cmndArgms[0];

                if (command == "Add Stop")
                {
                    int index = int.Parse(cmndArgms[1]);
                    string insertString = cmndArgms[2];

                    if (index >= 0 && index < text.Length)
                    {
                        text = text.Insert(index, insertString);
                        Console.WriteLine(text);
                    }
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(cmndArgms[1]);
                    int endIndex = int.Parse(cmndArgms[2]);

                    if (startIndex >= 0 && endIndex >= 0 
                                        && startIndex < text.Length 
                                        && endIndex < text.Length)
                    {
                        int count = endIndex - startIndex;
                        text = text.Remove(startIndex, count+1);
                    }
                    Console.WriteLine(text);
                }
                else if (command == "Switch")
                {
                    string oldString = cmndArgms[1];
                    string newString = cmndArgms[2];

                    if (text.Contains(oldString))
                    {
                        text = text.Replace(oldString, newString);
                        Console.WriteLine(text);
                    }
                }       

                input = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
        }
    }
}
