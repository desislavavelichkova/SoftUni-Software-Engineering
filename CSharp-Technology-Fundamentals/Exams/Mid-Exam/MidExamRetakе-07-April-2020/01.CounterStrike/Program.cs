using System;

namespace _01.CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wins = 0;
            int battle = 0;
            bool isWinner = true;

            string input = Console.ReadLine();

            while (input != "End of battle")
            {
                battle++;
                int distance = int.Parse(input);                          

                if (energy < distance)
                {                    
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    isWinner = false;
                    break;
                }

                wins++;
                energy -= distance;                

                if (battle % 3 == 0)
                {
                    energy += wins;
                }
               
                input = Console.ReadLine();
            }

            if (isWinner)
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
            }
            
        }
    }
}
