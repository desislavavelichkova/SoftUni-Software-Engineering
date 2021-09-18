using System;

namespace _3.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;

            if (typeOfGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 10.46;
                }
                double totalPrice = price * groupOfPeople;
                if (groupOfPeople >= 30)
                {
                    totalPrice *= 0.85;
                }
                Console.WriteLine($"Total price: {totalPrice:f2}");

            }
            else if (typeOfGroup == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 16;
                }
                double totalPrice = price * groupOfPeople;
                if (groupOfPeople >= 100)
                {
                    totalPrice -= price * 10; 
                }
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }
            else if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = 22.50;
                }
                double totalPrice = price * groupOfPeople;

                if (groupOfPeople >= 10 && groupOfPeople <= 20 )
                {
                    totalPrice *= 0.95;
                }
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }
        }
    }
}
