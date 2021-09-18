using System;

namespace _9.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int totalConsumeCrew = 0;
            int dayCounter = 0;
            
            while (startingYield >= 100)
            {
                dayCounter++;
                int consumeCrew = startingYield - 26;
                totalConsumeCrew += consumeCrew;
                startingYield -= 10;                
            }
            
            if (startingYield < 100 && dayCounter > 0 )
            {
                totalConsumeCrew -= 26;
            }
            Console.WriteLine(dayCounter);
            Console.WriteLine(totalConsumeCrew);
        }
    }
}
