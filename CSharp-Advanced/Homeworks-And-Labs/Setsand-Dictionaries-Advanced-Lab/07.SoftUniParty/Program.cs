using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuest = new HashSet<string>();

            while (input != "PARTY")
            {
                if (input[0] >= 47 && input[0] <= 57)
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuest.Add(input);
                }

                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            while (input != "END")
            {
                if (vipGuests.Contains(input))
                {
                    vipGuests.Remove(input);
                }
                if (regularGuest.Contains(input))
                {
                    regularGuest.Remove(input);
                }
                input = Console.ReadLine();
            }
            int countGuest = vipGuests.Count + regularGuest.Count;
            Console.WriteLine(countGuest);
            if (vipGuests.Count > 0)
            {
                foreach (var guest in vipGuests)
                {
                    Console.WriteLine(guest);
                }
            }
            if (regularGuest.Count > 0 )
            {
                foreach (var guest in regularGuest)
                {
                    Console.WriteLine(guest);
                }
            }

        }
    }
}
