using System;

namespace _01.EasterCozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double priceForFlour = double.Parse(Console.ReadLine());
            double priceForEggs = priceForFlour * 0.75;
            double priceForMilk = priceForFlour * 1.25;

            double productsForCozonac = priceForEggs + priceForFlour + 0.25 * priceForMilk;
            
            int currentCozonacsCount = 0;
            int coloredEggs = 0;            

            while (budget >= productsForCozonac)
            {
                budget -= productsForCozonac;
                currentCozonacsCount++;
                coloredEggs += 3;

                if (currentCozonacsCount % 3 == 0)
                {
                    coloredEggs -= currentCozonacsCount - 2;
                }
            }

            Console.WriteLine($"You made {currentCozonacsCount} cozonacs! Now you have {coloredEggs} eggs and {budget:f2}BGN left.");
            
        }
    }
}
