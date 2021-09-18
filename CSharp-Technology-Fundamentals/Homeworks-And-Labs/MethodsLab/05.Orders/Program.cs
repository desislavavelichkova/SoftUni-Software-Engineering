using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string input = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0;

            switch (input)
            {
                case "coffee":                    
                    TotalPriceForCoffee(price,quantity);
                    break;
                case "water":
                    TotalPriceForWater(price,quantity);
                    break;
                case "coke":
                    TotalPriceForCoke(price,quantity);
                    break;
                case "snacks":
                    TotalPriceForSnacks(price,quantity);
                    break;
            }
        }
        static void TotalPriceForCoffee (double price, int quantity)
        {
            price = 1.50;
            double totalPrice = price * quantity;
            Console.WriteLine($"{totalPrice:f2}");
        }
        static void TotalPriceForWater(double price, int quantity)
        {
            price = 1.00;
            double totalPrice = price * quantity;
            Console.WriteLine($"{totalPrice:f2}");
        }
        static void TotalPriceForCoke(double price, int quantity)
        {
            price = 1.40;
            double totalPrice = price * quantity;
            Console.WriteLine($"{totalPrice:f2}");
        }
        static void TotalPriceForSnacks(double price, int quantity)
        {
            price = 2.0;
            double totalPrice = price * quantity;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
