using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MagicCards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine()
                            .Split(":", StringSplitOptions.RemoveEmptyEntries)
                            .ToList();

            string input = Console.ReadLine();

            List<string> newCards = new List<string>();

            while (input != "Ready")
            {
                string[] cmndArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

                string command = cmndArgs[0];
                string card = cmndArgs[1];

                if (command == "Add")
                {
                    if (cards.Contains(card))
                    {
                        newCards.Add(card);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");                        
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(cmndArgs[2]);

                    
                    if (cards.Contains(card) && (index >= 0 && index < newCards.Count))
                    {
                        newCards.Insert(index, card);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }

                else if (command == "Remove")
                {
                    if (newCards.Contains(card))
                    {
                        newCards.Remove(card);                        
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command == "Swap")
                {
                    string secondCard = cmndArgs[2];

                    int firstIndex = newCards.IndexOf(card);
                    int secondIndex = newCards.IndexOf(secondCard);

                    string crd1 = newCards[firstIndex];
                    string crd2 = newCards[secondIndex];

                    newCards[firstIndex] = crd2;
                    newCards[secondIndex] = crd1;
                }

                else if (command == "Shuffle")
                {
                    newCards.Reverse();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", newCards));
        }
    }
}
