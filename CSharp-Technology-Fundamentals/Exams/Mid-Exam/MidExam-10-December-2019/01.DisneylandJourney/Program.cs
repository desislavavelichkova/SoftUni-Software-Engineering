using System;

namespace _01.DisneylandJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            double savemoney = 0;
           

            for (int i = 1; i <= month; i++)
            {

                if (i > 2 && i % 2 != 0)
                {
                    savemoney -= savemoney * 0.16;
                }

                if (i % 4 == 0)
                {
                    savemoney += savemoney * 0.25;
                }

                savemoney += buget * 0.25;

            }
            if (savemoney >= buget)
            {
                double moneyForSouvenirs = savemoney - buget;
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {moneyForSouvenirs:f2}lv. for souvenirs.");
            }
            else if (savemoney < buget)
            {
                double neededMoney = buget - savemoney;
                Console.WriteLine($"Sorry. You need {neededMoney:f2}lv. more.");
            }
        }
    }
}
