using System;
using System.Dynamic;

namespace _07.WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeOfDay = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            if (timeOfDay >= 10 && timeOfDay <= 18)
            {
                if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday" || dayOfWeek == "Saturday")

                {
                    Console.WriteLine("open");
                }

                else if (dayOfWeek == "Sunday")
                {
                    Console.WriteLine("closed");
                }
            }

            else 
            {
                if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday" || dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                {
                    Console.WriteLine("closed");
                }
                
            }
        }
    }
}
