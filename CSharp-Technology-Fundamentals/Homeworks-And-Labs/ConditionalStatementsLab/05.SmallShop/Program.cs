using System;

namespace _05.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //       coffee   water   beer   sweets  peanuts
            //Sofia   0.50    0.80    1.20    1.45    1.60
            //Plovdiv 0.40    0.70    1.15    1.30    1.50
            //Varna   0.45    0.70    1.10    1.35    1.55

            string product = Console.ReadLine();
            string tawn = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
           
            if (tawn == "Sofia")
            {
                if (product == "coffee")
                {
                    double PriceForCoffee = quantity * 0.50;
                    Console.WriteLine(PriceForCoffee);
                }
                else if (product == "water")
                {
                    double PriceForWater = Math.Round(quantity * 0.80, 2);
                    Console.WriteLine(PriceForWater);
                }
                else if (product == "beer")
                {
                    double PriceForBeer = quantity * 1.20;
                    Console.WriteLine(PriceForBeer);
                }
                else if (product == "sweets")
                {
                    double PriceForSweets = Math.Round( quantity * 1.45, 4);
                    Console.WriteLine(PriceForSweets);
                }
                else if (product == "peanuts")
                {
                    double PriceForPeanuts = quantity * 1.60;
                    Console.WriteLine(PriceForPeanuts);
                } 
            }
            else if (tawn == "Plovdiv")
            {
                if (product == "coffee")
                {
                    double PriceForCoffe = quantity * 0.40;
                    Console.WriteLine(PriceForCoffe);
                }
                else if (product == "water")
                {
                    double PriceForWater = Math.Round(quantity * 0.70, 2);
                    Console.WriteLine(PriceForWater);
                }
                else if (product == "beer")
                {
                    double PriceForBeer = quantity * 1.15;
                    Console.WriteLine(PriceForBeer);
                }
                else if (product == "sweets")
                {
                    double PriceForSweets = Math.Round( quantity * 1.30, 4);
                    Console.WriteLine(PriceForSweets);
                }
                else if (product == "peanuts")
                {
                    double PriceForPeanuts = quantity * 1.50;
                    Console.WriteLine(PriceForPeanuts);
                }
            }
            if (tawn == "Varna")
            {
                if (product == "coffee")
                {
                    double PriceForCoffee = quantity * 0.45;
                    Console.WriteLine(PriceForCoffee);
                }
                else if (product == "water")
                {
                    double PriceForWater = Math.Round( quantity * 0.70, 2);
                    Console.WriteLine(PriceForWater);
                }
                else if (product == "beer")
                {
                    double PriceForBeer = quantity * 1.10;
                    Console.WriteLine(PriceForBeer);
                }
                else if (product == "sweets")
                {
                    double PriceForSweets = Math.Round( quantity * 1.35, 4);
                    Console.WriteLine(PriceForSweets);
                }
                else if (product == "peanuts")
                {
                    double PriceForPeanuts = quantity * 1.55;
                    Console.WriteLine(PriceForPeanuts);
                }
            }
        }
    }
}
