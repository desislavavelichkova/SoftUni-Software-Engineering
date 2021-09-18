using System;

namespace _1.IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());
            int fourthInteger = int.Parse(Console.ReadLine());

            int totalInteger = (int)((firstInteger + secondInteger) / thirdInteger) * fourthInteger;

            Console.WriteLine(totalInteger);

        }
    }
}
