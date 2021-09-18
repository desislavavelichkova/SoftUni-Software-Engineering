using System;

namespace _6.DailyWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int raw = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            double totalMoney= 0;
            int countPosition = 0;
            int countRaw = 0;
            double totalMoneyForRaw = 0;
            double totalMoneyPerPosition = 0;

            for (int i = 1; i <= raw; i++)
            {
                for (int j = 1; j <= position; j++)
                {
                    if ( i % 2 != 0)
                    {
                        countRaw++;
                        totalMoneyForRaw = countRaw * 3.5;
                    }

                    if (i % 2 == 0 && j % 3 != 0)
                    {
                        countPosition++;
                        totalMoneyPerPosition = countPosition * 5.0;
                    }
                }
            }
            totalMoney = totalMoneyForRaw + totalMoneyPerPosition;
            double totalSellMoney = totalMoney * 0.80;
            Console.WriteLine($"Total: {totalSellMoney:f2} lv.");
        }
    }
}
