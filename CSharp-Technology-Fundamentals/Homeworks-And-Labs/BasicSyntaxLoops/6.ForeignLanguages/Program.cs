using System;

namespace _6.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine();

            if (country == "England" || country == "USA")
            {
                Console.WriteLine("English");
            }
            else if (country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
