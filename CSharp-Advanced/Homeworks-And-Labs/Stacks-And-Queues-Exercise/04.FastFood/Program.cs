using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] customers = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();
          

            Queue<int> orders = new Queue<int>(customers);
            int biggestOrder = orders.Max();

            int totalOrders = 0;

            for (int i = 0; i < customers.Length; i++)
            {
                totalOrders += customers[i];

                if (totalOrders <= quantityFood)
                {                    
                    orders.Dequeue();
                }  
            }
              
            Console.WriteLine(biggestOrder);

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else 
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
        }
    }
}
