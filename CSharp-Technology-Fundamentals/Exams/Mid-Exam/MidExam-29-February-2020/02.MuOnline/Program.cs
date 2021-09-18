using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine()
                            .Split('|', StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
            

            int health = 100;
            int bitcoins = 0;
            int countRooms = 0;
            
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] input = rooms[i]
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                                
                string command = input[0];
                int points = int.Parse(input[1]);

                countRooms++;
                   
                if (health > 0 && health <= 100)
                {
                    if (command == "potion")
                    {                       
                        health += points;                        

                        if (health > 100)
                        {
                            points = Math.Abs(health - points - 100);
                            health = 100;
                            
                        }
                        
                        Console.WriteLine($"You healed for {points} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    
                    else if (command == "chest")
                    {
                        bitcoins += points;
                        Console.WriteLine($"You found {points} bitcoins.");
                    }

                    else if (command != "potion" && command != "chest")
                    {
                        health -= points;
                        if (health > 0 && health <= 100)
                        {
                            Console.WriteLine($"You slayed {command}.");
                            
                        }
                        
                         else if (health <= 0)
                         {
                             Console.WriteLine($"You died! Killed by {command}.");
                            Console.WriteLine($"Best room: {countRooms}");
                            Environment.Exit(0);
                         }                                               
                    }
                }      
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");

        }
    }
}
