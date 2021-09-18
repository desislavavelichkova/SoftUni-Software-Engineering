using System;

namespace _4.CenturiesТoMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            Console.WriteLine($"{centuries} centuries = {centuries * 100} years = {Math.Floor(centuries * 100 * 365.2422)} days = {Math.Floor(centuries * 100 * 365.2422)*24} hours = {Math.Floor(centuries * 100 * 365.2422) * 24*60} minutes");
        }
    }
}
