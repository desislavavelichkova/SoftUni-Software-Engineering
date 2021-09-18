using System;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle car = GetVehicleType();
            Vehicle truck = GetVehicleType();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmndArgs = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmndArgs[0];
                string typeOfVehicle = cmndArgs[1];
                double parametre = double.Parse(cmndArgs[2]);

                if (command == "Drive")
                {
                    try
                    {
                    
                        if (typeOfVehicle == nameof(Car))
                        {
                            car.Drive(parametre);
                            Console.WriteLine($"{nameof(Car)} travelled {parametre} km");
                        }
                        else
                        {
                            truck.Drive(parametre);
                            Console.WriteLine($"{nameof(Truck)} travelled {parametre} km"); ;
                        }                        
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (command == "Refuel")
                {
                    if (typeOfVehicle == nameof(Car))
                    {
                        car.Refuel(parametre);
                    }
                    else
                    {
                        truck.Refuel(parametre);
                    }
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }
        private static Vehicle GetVehicleType()
        {
            Vehicle vehicle = null;

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string typeOfVehicle = input[0];
            double fuel = double.Parse(input[1]);
            double consumption = double.Parse(input[2]);

            if (typeOfVehicle == nameof(Car))
            {
                vehicle = new Car(fuel, consumption);
            }
            else
            {
                vehicle = new Truck(fuel, consumption);
            }            

            return vehicle;
        }

    }
}
