using System;

namespace _3.KartCenter_ProblemDescription
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputMoney = double.Parse(Console.ReadLine());
            string rounds = Console.ReadLine();
            string fenCard = Console.ReadLine();
            string typeOfCard = Console.ReadLine();

            double priceForRound = 0;
            double discount = 0;

            if (rounds == "five")
            {
                switch (typeOfCard)
                {
                    case "Child":
                        priceForRound = 7;
                        break;
                    case "Junior":
                        priceForRound = 9;
                        break;
                    case "Adult":
                        priceForRound = 12;
                        break;
                    case "Profi":
                        priceForRound = 18;
                        break;
                }
                if (fenCard == "yes")
                {
                    discount = priceForRound * 0.20;
                }
                else if (fenCard == "no")
                {
                    discount = 0;
                }
            }
            else if (rounds == "ten")
            {
                switch (typeOfCard)
                {
                    case "Child":
                        priceForRound = 11;
                        break;
                    case "Junior":
                        priceForRound = 16;
                        break;
                    case "Adult":
                        priceForRound = 21;
                        break;
                    case "Profi":
                        priceForRound = 32;
                        break;
                }
                if (fenCard == "yes")
                {
                    discount = priceForRound * 0.20;
                }
                else if (fenCard == "no")
                {
                    discount = 0;
                }
            }
            double totalMoney = priceForRound - discount;

            if (inputMoney >= totalMoney)
            {
                double moneyLeft = inputMoney - totalMoney;
                Console.WriteLine($"You bought {typeOfCard} ticket for {rounds} laps. Your change is {moneyLeft:f2}lv.");
            }
            else if (inputMoney < totalMoney)
            {
                double neededMoney = totalMoney - inputMoney;
                Console.WriteLine($"You don't have enough money! You need {neededMoney:f2}lv more.");
            }
        }
    }
}
