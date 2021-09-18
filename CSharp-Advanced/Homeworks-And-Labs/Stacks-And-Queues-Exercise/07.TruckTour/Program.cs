using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumps = int.Parse(Console.ReadLine());

            Queue<string> pumpsData = new Queue<string>();

            for (int i = 0; i < pumps; i++)
            {
                string data = Console.ReadLine();
                pumpsData.Enqueue(data);
            }

            for (int i = 0; i < pumps; i++)
            {

                decimal currentAmountPetrol = 0;
                bool isSuccssecfull = true;

                for (int j = 0; j < pumps; j++)
                {
                    string pumpDataStr = pumpsData.Dequeue();
                    decimal[] pumpData = pumpDataStr.Split(" ").Select(decimal.Parse).ToArray();

                    pumpsData.Enqueue(pumpDataStr);

                    currentAmountPetrol += pumpData[0];
                    currentAmountPetrol -= pumpData[1];

                    if (currentAmountPetrol < 0)
                    {
                        isSuccssecfull = false;
                    }
                }

                if (isSuccssecfull)
                {
                    Console.WriteLine(i);
                    break;
                }

                string temdDate = pumpsData.Dequeue();
                pumpsData.Enqueue(temdDate);

            }
        }
    }
}
