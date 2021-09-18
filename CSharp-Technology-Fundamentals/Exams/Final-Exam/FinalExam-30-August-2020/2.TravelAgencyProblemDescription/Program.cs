using System;

namespace _2.TravelAgencyProblemDescription
{
    class Program
    {
        static void Main(string[] args)
        {
            int tickets = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            int priceForTicket = int.Parse(Console.ReadLine());

            int totalMoney = tickets * priceForTicket;

            if (budget < totalMoney)
            {
                Console.WriteLine($"The budget of {budget}$ is not enough. Your client can't buy {tickets} tickets with this budget!");
            }
            else if (budget >= totalMoney)
            {
                int change = budget - totalMoney;
                Console.WriteLine($"You can sell your client {tickets} tickets for the price of {totalMoney}$!");
                Console.WriteLine($"Your client should become a change of {change}$!");
            }

        }
    }
}
