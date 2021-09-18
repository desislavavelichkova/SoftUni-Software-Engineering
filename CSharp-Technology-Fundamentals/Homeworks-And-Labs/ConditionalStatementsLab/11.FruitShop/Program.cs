using System;

namespace _11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //плод           banana   apple   orange  grapefruit  kiwi    pineapple    grapes
            //цена week       2.50    1.20    0.85     1.45      2.70      5.50       3.85
            //цена weekend	  2.70	  1.25	  0.90	   1.60	     3.00	   5.60	      4.20
            
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (day == "Monday" || day == "Friday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday")

            {
                if (fruit == "banana")
                {
                    double PriceForBanana = quantity * 2.50;
                    Console.WriteLine($"{PriceForBanana:f2}");
                }

                else if (fruit == "apple")
                {
                    double PriceForApple = quantity * 1.20;
                    Console.WriteLine($"{PriceForApple:f2}");
                }
                else if (fruit == "orange")
                {
                    double PriceForOrange = quantity * 0.85;
                    Console.WriteLine($"{PriceForOrange:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    double PriceForGrapefruit = quantity * 1.45;
                    Console.WriteLine($"{PriceForGrapefruit:f2}");
                }
                else if (fruit == "kiwi")
                {
                    double PriceForKiwi = quantity * 2.70;
                    Console.WriteLine($"{PriceForKiwi:f2}");
                }
                else if (fruit == "pineapple")
                {
                    double PriceForPineapple = quantity * 5.50;
                    Console.WriteLine($"{PriceForPineapple:f2}");
                }
                else if (fruit == "grapes")
                {
                    double PriceForGrapes = quantity * 3.85;
                    Console.WriteLine($"{PriceForGrapes:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    double PriceForBanana = quantity * 2.70;
                    Console.WriteLine($"{PriceForBanana:f2}");
                }
                else if (fruit == "apple")
                {
                    double PriceForApple = quantity * 1.25;
                    Console.WriteLine($"{PriceForApple:f2}");
                }
                else if (fruit == "orange")
                {
                    double PriceForOrange = quantity * 0.90;
                    Console.WriteLine($"{PriceForOrange:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    double PriceForGrapefruit = quantity * 1.60;
                    Console.WriteLine($"{PriceForGrapefruit:f2}");
                }
                else if (fruit == "kiwi")
                {
                    double PriceForKiwi = quantity * 3.00;
                    Console.WriteLine($"{PriceForKiwi:f2}");
                }
                else if (fruit == "pineapple")
                {
                    double PriceForPineapple = quantity * 5.60;
                    Console.WriteLine($"{PriceForPineapple:f2}");
                }
                else if (fruit == "grapes")
                {
                    double PriceForGrapes = quantity * 4.20;
                    Console.WriteLine($"{PriceForGrapes:f2}");
                }
                else 
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
