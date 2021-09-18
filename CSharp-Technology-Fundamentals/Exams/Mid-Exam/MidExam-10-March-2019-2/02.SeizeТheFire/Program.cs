using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SeizeТheFire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> typeOfFireAndCell = Console.ReadLine()
                                         .Split("#", StringSplitOptions.RemoveEmptyEntries)
                                         .ToList();

            int water = int.Parse(Console.ReadLine());
            double effort = 0;
            int totalFire = 0;

            List<int> cell = new List<int>();

            for (int i = 0; i < typeOfFireAndCell.Count; i++)
            
            {
                string[] leveOfFire = typeOfFireAndCell.ToArray();       
                string cellFire = leveOfFire[i];
                string[] firePrmts = cellFire.Split(" = ").ToArray();

                string typeOfFire = firePrmts[0];
                int valueOfCell = int.Parse(firePrmts[1]);

                if (typeOfFire == "High" && valueOfCell >= 81 && valueOfCell <= 125 && water >= valueOfCell)
                {
                    water -= valueOfCell;
                    effort += (valueOfCell * 0.25);
                    totalFire += valueOfCell;
                    cell.Add(valueOfCell);
                }

                else if (typeOfFire == "Medium" && valueOfCell >= 51 && valueOfCell <= 80 && water >= valueOfCell)
                {
                    water -= valueOfCell;
                    effort += (valueOfCell * 0.25);
                    totalFire += valueOfCell;
                    cell.Add(valueOfCell);

                }
                else if (typeOfFire == "Low" && valueOfCell >= 1 && valueOfCell <= 50 && water >= valueOfCell)
                {
                    water -= valueOfCell;
                    effort += (valueOfCell * 0.25);
                    totalFire += valueOfCell;
                    cell.Add(valueOfCell);
                }
            }
                        
            Console.WriteLine("Cells:");
            for (int i = 0; i < cell.Count; i++)
            {
                Console.WriteLine($"- {cell[i]}");
            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
