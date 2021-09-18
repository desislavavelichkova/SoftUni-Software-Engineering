using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int horsePower = int.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            double kilometers = double.Parse(Console.ReadLine());

            FamilyCar car = new FamilyCar(horsePower, fuel);

           
        }
    }
}
