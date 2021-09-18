using System;

namespace VehiclesExtension
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle car = GetVehicleType();
            Vehicle truck = GetVehicleType();
            Vehicle bus = GetVehicleType();            

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmndArgs = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = cmndArgs[0];
                string typeOfVehicle = cmndArgs[1];
                double parametre = double.Parse(cmndArgs[2]);

                if (parametre <= 0)
                {
                    Console.WriteLine("Fuel must be a positive number");
                    continue;
                }

                if (command == "Drive")
                {
                    try
                    {                    
                        if (typeOfVehicle == nameof(Car))
                        {
                            car.Drive(parametre);
                            Console.WriteLine($"{nameof(Car)} travelled {parametre} km");
                        }
                        else if(typeOfVehicle == nameof(Truck))
                        {
                            truck.Drive(parametre);
                            Console.WriteLine($"{nameof(Truck)} travelled {parametre} km"); 
                        }
                        else
                        {
                            bus.Drive(parametre);
                            Console.WriteLine($"{nameof(Bus)} travelled {parametre} km"); 
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (command == "DriveEmpty")
                {
                    try
                    {
                        if (typeOfVehicle == nameof(Bus))
                        {
                            bus.DriveEmpty(parametre);
                            Console.WriteLine($"{nameof(Bus)} travelled {parametre} km");
                        }
                        else
                        {
                            continue;
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (command == "Refuel")
                {
                    try
                    {                   
                        
                        if (typeOfVehicle == nameof(Car))
                        {
                            car.Refuel(parametre);
                        }
                        else if(typeOfVehicle == nameof(Truck))
                        {
                            truck.Refuel(parametre);
                        }
                        else
                        {
                            bus.Refuel(parametre);
                        }
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
        private static Vehicle GetVehicleType()
        {
            Vehicle vehicle = null;

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string typeOfVehicle = input[0];
            double fuel = double.Parse(input[1]);
            double consumption = double.Parse(input[2]);
            double tankCapacity = double.Parse(input[3]);

            if (fuel > tankCapacity)
            {
                fuel = 0;
            }
            if (typeOfVehicle == nameof(Car))
            {
                vehicle = new Car(fuel, consumption, tankCapacity);
            }
            else if (typeOfVehicle == nameof(Truck))
            {
                vehicle = new Truck(fuel, consumption, tankCapacity);
            }
            else
            {
                vehicle = new Bus(fuel, consumption, tankCapacity);
            }           

            return vehicle;
        }

    }
}
