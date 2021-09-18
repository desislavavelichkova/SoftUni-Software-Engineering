using System;

namespace _9.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountMoney = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double freeBelt = 0;
            
            if (countStudents % 6 == 0)
            {
                freeBelt = countStudents / 6.0;
            }

            double totalMoney = ((Math.Ceiling(countStudents * 1.1) * lightsabersPrice) + (countStudents * robesPrice*1.0) + ((countStudents - freeBelt) * beltPrice));
            
            if (totalMoney <= amountMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");
            }
            else if (amountMoney < totalMoney)
            {
                double neededMoney = totalMoney - amountMoney;
                Console.WriteLine($"Ivan Cho will need {neededMoney:f2}lv more.");
            }
        }
    }
}
