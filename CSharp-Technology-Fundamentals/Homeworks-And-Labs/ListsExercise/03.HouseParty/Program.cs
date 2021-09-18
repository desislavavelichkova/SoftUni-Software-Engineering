using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGuest = int.Parse(Console.ReadLine());

           // string input = Console.ReadLine();
            
            List<string> guest = new List<string>();

            for (int i = 0; i < numberOfGuest; i++)
            {
                string[] input = Console.ReadLine().Split();
                string nameOfGuest = input[0];

                if (input.Length == 3)
                {
                    if (guest.Contains(nameOfGuest))
                    {
                        Console.WriteLine($"{nameOfGuest} is already in the list!");
                    }
                    else if (!guest.Contains(nameOfGuest))
                    {
                        guest.Add(nameOfGuest);
                    }      
                }

                else if (input.Length > 3)
                {
                    if (guest.Contains(nameOfGuest))
                    {
                        guest.Remove(nameOfGuest);
                    }
                    else
                    {
                        Console.WriteLine($"{nameOfGuest} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join (Environment.NewLine,guest));
        }
    }
}
