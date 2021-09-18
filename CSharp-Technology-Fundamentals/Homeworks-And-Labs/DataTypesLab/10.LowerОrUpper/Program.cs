using System;

namespace _10.LowerОrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
           char charecter = char.Parse(Console.ReadLine());
            if (charecter >= 65 && charecter <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
