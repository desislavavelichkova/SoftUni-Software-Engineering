using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>\d+\.?\d*)\$";
            Regex regex = new Regex(pattern);
           
            double income = 0;

            string input = Console.ReadLine();
           
            while (input != "end of shift")
            {
                Match matchCustomer = regex.Match(input);

                if (matchCustomer.Success)
                {
                    string name = matchCustomer.Groups["name"].Value;
                    string product = matchCustomer.Groups["product"].Value;
                    int quantity = int.Parse(matchCustomer.Groups["quantity"].Value);
                    double price = double.Parse(matchCustomer.Groups["price"].Value);
                    double totalPrice = quantity * price;
                    income += totalPrice;
                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                }
                
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}
