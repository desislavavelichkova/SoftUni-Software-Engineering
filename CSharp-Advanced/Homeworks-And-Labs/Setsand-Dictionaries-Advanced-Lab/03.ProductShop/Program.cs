using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, Dictionary<string, double>> markets = new Dictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Revision")
            {                
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!markets.ContainsKey(shop))
                {
                    markets.Add(shop, new Dictionary<string, double>());
                }
                if (!markets[shop].ContainsKey(product))
                {
                    markets[shop].Add(product, 0);
                }

                markets[shop][product] = price;

                input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var shop in markets.OrderBy(shop => shop.Key))
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value} ");
                }

            }
        }
    }
}
