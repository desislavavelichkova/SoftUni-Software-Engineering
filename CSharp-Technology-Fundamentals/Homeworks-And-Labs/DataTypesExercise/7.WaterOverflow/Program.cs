using System;

namespace _7.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacityOfWaterTank = 255;
            int n = int.Parse(Console.ReadLine());
            int totalWater = 0;

            for (int i = 0; i < n; i++)
            {
                int quantitiesOfWater = int.Parse(Console.ReadLine());

                totalWater += quantitiesOfWater;

                if (capacityOfWaterTank < totalWater )
                {
                    totalWater -= quantitiesOfWater;
                    Console.WriteLine("Insufficient capacity!");
                }
                
            }
            Console.WriteLine(totalWater);
        }
    }
}
