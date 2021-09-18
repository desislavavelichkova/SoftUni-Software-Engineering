using System;

namespace _13.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string report = Console.ReadLine();
            
            if (typeOfRoom == "room for one person")
            {
                if ( days < 10)
                {
                    double totalPrice = (days - 1) * 18;

                    if (report == "positive")
                    {
                        double positiveTotalPrice = (totalPrice * 0.25) + totalPrice;
                        Console.WriteLine($"{positiveTotalPrice:f2}");
                    }
                    else if(report == "negative")
                    {
                        double negativeTotalPrice = totalPrice - (totalPrice * 0.10);
                        Console.WriteLine($"{negativeTotalPrice:f2}");
                    }

                }
                else if (days >= 10 && days < 15)
                {
                    double totalPrice = (days - 1) * 18;
                    if (report == "positive")
                    {
                        double positiveTotalPrice = (totalPrice * 0.25) + totalPrice;
                        Console.WriteLine($"{positiveTotalPrice:f2}");
                    }
                    else if (report == "negative")
                    {
                        double negativeTotalPrice = totalPrice - (totalPrice * 0.10);
                        Console.WriteLine($"{negativeTotalPrice:f2}");
                    }
                }
                else if (days >= 15)
                {
                    double totalPrice = (days - 1) * 18;
                    if (report == "positive")
                    {
                        double positiveTotalPrice = (totalPrice * 0.25) + totalPrice;
                        Console.WriteLine($"{positiveTotalPrice:f2}");
                    }
                    else if (report == "negative")
                    {
                        double negativeTotalPrice = totalPrice - (totalPrice * 0.10);
                        Console.WriteLine($"{negativeTotalPrice:f2}");
                    }
                }
            }
            else if (typeOfRoom == "apartment")
            {
                if (days < 10)
                {
                    double totalPrice = (days - 1) * 25 * 0.7;
                    if (report == "positive")
                    {
                        double positiveTotalPrice = (totalPrice * 0.25) + totalPrice;
                        Console.WriteLine($"{positiveTotalPrice:f2}");
                    }
                    else if (report == "negative")
                    {
                        double negativeTotalPrice = totalPrice - (totalPrice * 0.10);
                        Console.WriteLine($"{negativeTotalPrice:f2}");
                    }
                }
                else if (days >= 10 && days < 15)
                {
                    double totalPrice = (days - 1) * 25 * 0.65;
                    if (report == "positive")
                    {
                        double positiveTotalPrice = (totalPrice * 0.25) + totalPrice;
                        Console.WriteLine($"{positiveTotalPrice:f2}");
                    }
                    else if (report == "negative")
                    {
                        double negativeTotalPrice = totalPrice - (totalPrice * 0.10);
                        Console.WriteLine($"{negativeTotalPrice:f2}");
                    }
                }
                else if (days >= 15)
                {
                    double totalPrice = (days - 1) * 25 * 0.50;
                    if (report == "positive")
                    {
                        double positiveTotalPrice = (totalPrice * 0.25) + totalPrice;
                        Console.WriteLine($"{positiveTotalPrice:f2}");
                    }
                    else if (report == "negative")
                    {
                        double negativeTotalPrice = totalPrice - (totalPrice * 0.10);
                        Console.WriteLine($"{negativeTotalPrice:f2}");
                    }
                }
            }
            else if (typeOfRoom == "president apartment")
            {
                if (days < 10)
                {
                    double totalPrice = (days - 1) * 35 * 0.9;
                    if (report == "positive")
                    {
                        double positiveTotalPrice = (totalPrice * 0.25) + totalPrice;
                        Console.WriteLine($"{positiveTotalPrice:f2}");
                    }
                    else if (report == "negative")
                    {
                        double negativeTotalPrice = totalPrice - (totalPrice * 0.10);
                        Console.WriteLine($"{negativeTotalPrice:f2}");
                    }
                }
                else if (days >= 10 && days < 15)
                {
                    double totalPrice = (days - 1) * 35 * 0.75;
                    if (report == "positive")
                    {
                        double positiveTotalPrice = (totalPrice * 0.25) + totalPrice;
                        Console.WriteLine($"{positiveTotalPrice:f2}");
                    }
                    else if (report == "negative")
                    {
                        double negativeTotalPrice = totalPrice - (totalPrice * 0.10);
                        Console.WriteLine($"{negativeTotalPrice:f2}");
                    }
                }
                else if (days >= 15)
                {
                    double totalPrice = (days - 1) * 35 * 0.80;
                    if (report == "positive")
                    {
                        double positiveTotalPrice = (totalPrice * 0.25) + totalPrice;
                        Console.WriteLine($"{positiveTotalPrice:f2}");
                    }
                    else if (report == "negative")
                    {
                        double negativeTotalPrice = totalPrice - (totalPrice * 0.10);
                        Console.WriteLine($"{negativeTotalPrice:f2}");
                    }
                }
            }
        }
    }
}
