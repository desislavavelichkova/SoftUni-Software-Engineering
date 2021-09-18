using System;

namespace _3.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int person = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int numberOfCourses = (int)Math.Ceiling((double)person / capacity);
            Console.WriteLine(numberOfCourses);
        }
    }
}
