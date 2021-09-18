using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private readonly List<Car> data;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            data = new List<Car>();
        }
        public int Count { get { return data.Count; } }

        public string Type { get; set; }
        public int Capacity { get; set; }

        public void Add(Car car)
        {
            if (data.Count < Capacity)
            {
                data.Add(car);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            Car car = data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
            if (car == null)
            {
                return false;
            }
            else
            {
                data.Remove(car);
                return true;
            }
        }
        public Car GetLatestCar()
        {
            Car car = data.OrderByDescending(x => x.Year).FirstOrDefault();
            if (car == null)
            {
                return null;
            }           
            
            return car;

        }

        public Car GetCar(string manufacturer, string model)
        {
            Car car = data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
            if (car == null)
            {
                return null;
            }

            return car;
        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The cars are parked in {Type}:");
            foreach (var car in data)
            {
                sb.AppendLine($"{car}");
            }
            
            return sb.ToString();
        }
    }
}
