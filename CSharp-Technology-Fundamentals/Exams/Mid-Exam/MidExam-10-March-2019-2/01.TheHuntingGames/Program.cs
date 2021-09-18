using System;

namespace _01.TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfAdvature = int.Parse(Console.ReadLine());
            int countOfPlayers = int.Parse(Console.ReadLine());
            double energyOfGroup = double.Parse(Console.ReadLine());
            double waterPerDayPerPerson = double.Parse(Console.ReadLine());
            double foodPerDayPerPerson = double.Parse(Console.ReadLine());

            double waterPerGroup = countOfPlayers * waterPerDayPerPerson * daysOfAdvature;
            double foodPerGroup = countOfPlayers * foodPerDayPerPerson * daysOfAdvature;

            for (int i = 1; i <= daysOfAdvature; i++)
            {
                double energyLossChoppingWood = double.Parse(Console.ReadLine());

                energyOfGroup -= energyLossChoppingWood;

                if (energyOfGroup <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {foodPerGroup:f2} food and {waterPerGroup:f2} water.");
                    Environment.Exit(0);
                }

               
                if (i % 2 == 0)
                {
                    energyOfGroup *= 1.05;
                    waterPerGroup *= 0.70;
                }
                if (i % 3 == 0)
                {
                    energyOfGroup *= 1.10;
                    foodPerGroup -= (foodPerGroup / countOfPlayers);
                }
            }

            if (energyOfGroup > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energyOfGroup:f2} energy!");
            }
            
        }
    }
}
