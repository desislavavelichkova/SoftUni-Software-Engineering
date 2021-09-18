using System;
using System.Runtime;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double price = 0.0;
            double totalSpentMoney = 0.0;

            string input = Console.ReadLine();

            while (input != "Game Time")
            {
                if (   input != "OutFall 4" && input != "RoverWatch Origins Edition" 
                    && input != "CS: OG"    && input != "Zplinter Zell" 
                    && input != "Honored 2" && input != "RoverWatch")
                {
                    Console.WriteLine("Not Found");                    
                }

                switch (input)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;

                }

                if (currentBalance >= price)
                {
                    if (input == "OutFall 4" || input == "RoverWatch Origins Edition"
                    || input == "CS: OG" || input == "Zplinter Zell"
                    || input == "Honored 2" || input == "RoverWatch")
                    {
                        totalSpentMoney += price;
                        currentBalance -= price;
                        Console.WriteLine($"Bought {input}");
                        if (currentBalance <= 0)
                        {
                            Console.WriteLine("Out of money!");
                            Environment.Exit(0);
                        }
                    }
                }
                else if (currentBalance < price)
                {
                    Console.WriteLine("Too Expensive");                    
                }                   
                         
                input = Console.ReadLine();
            }

            if (input == "Game Time")
            {
                Console.WriteLine($"Total spent: ${totalSpentMoney}. Remaining: ${currentBalance:f2}");
            }

        }
    }
}
