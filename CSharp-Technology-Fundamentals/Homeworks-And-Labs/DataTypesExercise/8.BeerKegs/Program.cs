using System;

namespace _8.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxVolume = double.MinValue;
            string maxModel = "";
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;
                //Console.WriteLine(volume);
                if (maxVolume < volume)
                {
                    maxVolume = volume;
                    maxModel = model;
                    
                }
            }
            Console.WriteLine(maxModel);
        }
    }
}
