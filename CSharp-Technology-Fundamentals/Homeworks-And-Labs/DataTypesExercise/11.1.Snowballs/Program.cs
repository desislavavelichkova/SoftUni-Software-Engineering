using System;

namespace _11._1.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestSnowballSnow = 0;
            int bestTime = 0;
            double bestValue = 0;
            int bestQuality = 0;
Ю
            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());


                double snowballValue = Math.Pow((snowballSnow / snowballTime), snowballQuality);
                if (bestValue <= snowballValue)
                {
                    bestValue = snowballValue;
                    bestQuality = snowballQuality;
                    bestSnowballSnow = snowballSnow;
                    bestTime = snowballTime;

                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}
