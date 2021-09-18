using System;

namespace _4.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int minutesAfter30 = minutes + 30;

            if (minutesAfter30 > 59 && hours >= 0 && hours < 23)
            {
                hours += 1;
                minutesAfter30 = minutesAfter30 % 60;
            }
            else if (hours == 23 && minutesAfter30 > 59)
            {
                hours = 0;
                minutesAfter30 = minutesAfter30 % 60;
            }
            
            Console.WriteLine($"{hours}:{ minutesAfter30:d2}");
        }
    }
}
