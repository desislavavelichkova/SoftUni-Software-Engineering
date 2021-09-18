using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();
            

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string name = input[0];
                int age = int.Parse(input[1]);

                if (input.Length == 4)
                {
                    string id = input[2];
                    string birthday = input[3];
                                                     
                    buyers[name] = new Citizen(name, age, id, birthday);

                }
                else if (input.Length == 3)
                {
                    string group = input[2];

                    Rebel rebel = new Rebel(name, age, group);                   
                    buyers[name] = new Rebel(name, age, group);
                }
            }                       

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                if (!buyers.ContainsKey(input))
                {
                    continue;
                }

                IBuyer buyer = buyers[input];
                buyer.BuyFood();
            }

            int totalSum = buyers.Values.Sum(x => x.Food);
            Console.WriteLine(totalSum);
        }
    }
}
