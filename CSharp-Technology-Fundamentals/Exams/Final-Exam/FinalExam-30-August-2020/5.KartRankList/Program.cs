using System;

namespace _5.KartRankList
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            
            int countGold = 0;
            int countSilver = 0;
            int countBronze = 0;
            int minTime = int.MaxValue;

            while (name != "Finish")
            {
                int min = int.Parse(Console.ReadLine());
                int sec = int.Parse(Console.ReadLine());
                int time = (min*60) + sec;
                                
                if ( time < 55)
                {
                    countGold++;
                    //if (time <= minTime)
                    //{
                    //    minTime = time;
                    //    Console.WriteLine($"With {min} minutes and {sec} seconds {name} is the winner of the day!");
                    //}
                }
                if (time >=55 && time <= 85)
                {
                    countSilver++;
                    
                }
                if (time > 85 && time <= 120)
                {
                    countBronze++;
                    
                }
                name = Console.ReadLine();
            }
            if (name == "Finish")
            {
                Console.WriteLine($"Today's prizes are {countGold} Gold {countSilver} Silver and {countBronze} Bronze cards!");
            }

            
        }
    }
}
