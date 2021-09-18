using System;

namespace _01.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalAmount = 0;

            while (input != "special" && input != "regular")
            {
                double price = double.Parse(input);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }

                totalAmount += price;                
                input = Console.ReadLine();
            }

            double taxes = totalAmount * 0.20;
            double totalAmountWithTaxes = totalAmount + taxes;

            if (totalAmount == 0)
            {
                Console.WriteLine("Invalid order!");
                Environment.Exit(0);

            }
            if (input == "special")
            {
                totalAmountWithTaxes *= 0.90;
            }
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalAmount:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalAmountWithTaxes:f2}$");

        }
    }
}
