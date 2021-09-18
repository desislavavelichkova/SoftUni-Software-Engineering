using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.EasterGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gifts = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

            string input = Console.ReadLine();

            while (input != "No Money")
            {
                string[] command = input.Split(" ");

                string comndArgs = command[0];
                string giftName = command[1];

                if (comndArgs == "OutOfStock")
                {
                    for (int i = 0; i < gifts.Length; i++)
                    {
                        if (gifts[i] == giftName)
                        {
                            gifts[i] = "None";
                        }                        
                    }
                }

                else if (comndArgs == "Required")
                {
                    int index = int.Parse(command[2]);

                    if (index >= 0 && index < gifts.Length )
                    {
                        for (int i = 0; i < gifts.Length; i++)
                        {
                            if (i == index)
                            {
                                gifts[i] = giftName;
                            }
                        }
                    }
                }
                
                else if (comndArgs == "JustInCase")
                {
                    gifts[gifts.Length - 1] = giftName;
                     
                }

                input = Console.ReadLine();
            }

            string giftToRemove = "None";
            gifts = gifts.Where(val => val != giftToRemove).ToArray();
            Console.WriteLine(string.Join(" ", gifts));
        }
    }
}
