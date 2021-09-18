using System;

namespace PROBA
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentHigh = double.Parse(Console.ReadLine());
            double inputHigh = double.Parse(Console.ReadLine());
            double startingHigh = currentHigh - 30;
            int countJumps = 0;
            int countFailJumps = 0;

            while (true)
            {
                countJumps++;

                if (currentHigh >= inputHigh)
                {
                    if (inputHigh > startingHigh)
                    {
                        startingHigh += 5;
                        countFailJumps = 0;
                    }
                    else
                    {
                        countFailJumps++;
                    }
                    if (countFailJumps == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {startingHigh}cm after {countJumps} jumps.");
                        break;
                    }
                }
                else
                {
                    break;
                }
                
                inputHigh = double.Parse(Console.ReadLine());
            }

            if (currentHigh < inputHigh)
            {
               Console.WriteLine($"Tihomir succeeded, he jumped over {currentHigh}cm after {countJumps} jumps.");
            }
            
        }
    }
}
