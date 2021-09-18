using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Dictionary<string, int> productsAndQuantity = new Dictionary<string, int>();
            Dictionary<string, double> productsAndPrice = new Dictionary<string, double>();

            while (input != "buy")
            {
                string[] productPriceQuantity = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = productPriceQuantity[0];
                double price = double.Parse(productPriceQuantity[1]);
                int quantity = int.Parse(productPriceQuantity[2]);
                double lastPrice = price;

                if (productsAndQuantity.ContainsKey(name) == false && productsAndPrice.ContainsKey(name) == false)
                {
                    productsAndQuantity.Add(name, quantity);
                    productsAndPrice.Add(name, lastPrice);
                }
                else
                {
                    productsAndQuantity[name] += quantity;
                    productsAndPrice[name] = price;
                }
                input = Console.ReadLine();
            }

            foreach (var product in productsAndQuantity)        
            {                
                double pricePerAll = productsAndPrice[product.Key];
                double totalPrice = product.Value * pricePerAll;     
                
                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
            }            
        }
    }
}
