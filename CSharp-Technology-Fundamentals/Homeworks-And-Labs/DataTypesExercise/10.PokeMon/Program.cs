using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            long pokePowerN = long.Parse(Console.ReadLine());
            uint distanceM = uint.Parse(Console.ReadLine());
            uint exhaustionFactorY = uint.Parse(Console.ReadLine());

            int targetCount = 0;
            long startedPokePowerN = pokePowerN;

            while (pokePowerN >= distanceM)
            {                
                pokePowerN -= distanceM;

                if (pokePowerN > 0)
                {
                    if (startedPokePowerN == pokePowerN * 2.0)
                    {
                        pokePowerN /= exhaustionFactorY;
                    }
                }
                
                targetCount++;                
            }           
            
            Console.WriteLine(pokePowerN);
            Console.WriteLine(targetCount);

        }
    }
}
