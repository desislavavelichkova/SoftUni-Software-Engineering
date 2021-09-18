using System;

namespace _12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Град    0 ≤ s ≤ 500    500 < s ≤ 1 000     1 000 < s ≤ 10 000      s > 10 000
            //Sofia       5 %              7 %                   8 %                12 %
            //Varna     4.5 %            7.5 %                  10 %                13 %
            //Plovdiv   5.5 %              8 %                  12 %              14.5 %

            string city = Console.ReadLine();
            double sale = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if ( sale >= 0 && sale <= 500)
                {
                    Console.WriteLine($"{(sale * 0.05):f2}");
                }
                else if (sale > 500 && sale <= 1000)
                {
                    Console.WriteLine($"{(sale * 0.07):f2}");
                }
                else if (sale > 1000 && sale <= 10000)
                {
                    Console.WriteLine($"{(sale * 0.08):f2}");
                }
                else if (sale > 10000)
                {
                    Console.WriteLine($"{(sale * 0.12):f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (sale >= 0 && sale <= 500)
                {
                    Console.WriteLine($"{(sale * 0.045):f2}");
                }
                else if (sale > 500 && sale <= 1000)
                {
                    Console.WriteLine($"{(sale * 0.075):f2}");
                }
                else if (sale > 1000 && sale <= 10000)
                {
                    Console.WriteLine($"{(sale * 0.10):f2}");
                }
                else if (sale > 10000)
                {
                    Console.WriteLine($"{(sale * 0.13):f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (sale >= 0 && sale <= 500)
                {
                    Console.WriteLine($"{(sale * 0.055):f2}");
                }
                else if (sale > 500 && sale <= 1000)
                {
                    Console.WriteLine($"{(sale * 0.08):f2}");
                }
                else if (sale > 1000 && sale <= 10000)
                {
                    Console.WriteLine($"{(sale * 0.12):f2}");
                }
                else if (sale > 10000)
                {
                    Console.WriteLine($"{(sale * 0.145):f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
                {
                Console.WriteLine("error");
            }
        }
    }
}
