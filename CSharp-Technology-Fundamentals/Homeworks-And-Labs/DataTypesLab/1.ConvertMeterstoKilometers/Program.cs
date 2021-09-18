using System;

namespace _1.ConvertMeterstoKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meter = int.Parse(Console.ReadLine());
            double kilometer = meter / 1000.0;

            Console.WriteLine($"{kilometer:f2}");
        }
    }
}
