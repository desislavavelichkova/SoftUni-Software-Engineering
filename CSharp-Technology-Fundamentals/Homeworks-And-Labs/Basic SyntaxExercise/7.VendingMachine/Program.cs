using System;

namespace _7.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;

            while (input != "Start")
            {
                double money = double.Parse(input);

                if (money == 0.1 || money == 0.2
                                 || money == 0.5
                                 || money == 1
                                 || money == 2)
                {
                    sum += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");                    
                }
                input = Console.ReadLine();                                
            }

            input = Console.ReadLine();

            double nutsPrice = 2.0;
            double waterPrice = 0.7;
            double crispsPrice = 1.5;
            double sodaPrice = 0.8;
            double cokePrice = 1.0;

            while (input != "End")
            {                
                if (input == "Nuts" && sum >= nutsPrice)
                {
                    sum -= nutsPrice;
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
                else if (input == "Water" && sum >= waterPrice)
                {
                    sum -= waterPrice;
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
                else if (input == "Crisps" && sum >= crispsPrice)
                {
                    sum -= crispsPrice;
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
                else if (input == "Soda" && sum >= sodaPrice)
                {
                    sum -= sodaPrice;
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
                else if (input == "Coke" && sum >= cokePrice)
                {
                    sum -= cokePrice;
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
                else if (sum < cokePrice || sum < sodaPrice 
                                         || sum < nutsPrice 
                                         || sum < waterPrice
                                         || sum < crispsPrice)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else if (input != "Nuts" || input != "Water"
                                    || input != "Crisps"
                                    || input != "Soda"
                                    || input != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
