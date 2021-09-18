using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboadPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expenses = (Math.Floor(lostGamesCount*1.0 / 2) * headSetPrice) + (Math.Floor(lostGamesCount*1.0 / 3) * mousePrice) + (Math.Floor(lostGamesCount*1.0 / 6) * keyboadPrice) + (Math.Floor(lostGamesCount*1.0 / 12) * displayPrice);

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
