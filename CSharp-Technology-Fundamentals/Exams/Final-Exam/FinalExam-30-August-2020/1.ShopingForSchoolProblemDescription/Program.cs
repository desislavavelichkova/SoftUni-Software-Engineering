using System;

namespace _1.ShopingForSchoolProblemDescription
{
    class Program
    {
        static void Main(string[] args)
        {
            int packPensils = int.Parse(Console.ReadLine());
            int packPen = int.Parse(Console.ReadLine());
            int packPapersForDrawing = int.Parse(Console.ReadLine());
            int packNotebook = int.Parse(Console.ReadLine());

            double priceForPensils = 4.75;
            double priceForPen = 1.80;
            double priceForPapersForDrawing = 6.50;
            double priceForNotebook = 2.50;

            double neededMoney = (packPensils *1.0 * priceForPensils) + (packPen *1.0 * priceForPen) + (packPapersForDrawing * 1.0 * priceForPapersForDrawing) + (packNotebook *1.0 * priceForNotebook);
            double totalMoney = neededMoney  - (neededMoney * 0.05);
            Console.WriteLine($"Your total is {totalMoney:f2}lv");
        }
    }
}
