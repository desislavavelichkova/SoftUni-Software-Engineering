using System;

namespace _01.CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int i = 1; i <= countOfOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double pricePerOrder = (daysInMonth * capsulesCount) * pricePerCapsule;
                totalPrice += pricePerOrder;

                Console.WriteLine($"The price for the coffee is: ${pricePerOrder:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
