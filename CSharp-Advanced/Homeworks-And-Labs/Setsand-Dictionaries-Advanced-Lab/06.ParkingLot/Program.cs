using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            HashSet<string> carNumbers = new HashSet<string>();

            while (input[0] != "END")
            {
                string command = input[0];
                string carNumber = input[1];

                if (command == "IN")
                {
                    carNumbers.Add(carNumber);
                }
                if (command == "OUT")
                {
                    if (carNumbers.Contains(carNumber))
                    {
                        carNumbers.Remove(carNumber);
                    }
                }

                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }
            if (carNumbers.Count > 0)
            {
                foreach (var car in carNumbers)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
