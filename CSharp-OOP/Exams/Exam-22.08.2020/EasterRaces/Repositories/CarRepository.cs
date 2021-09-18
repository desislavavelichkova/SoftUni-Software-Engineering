using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories
{
    public class CarRepository : IRepository<ICar>
    {
        private Dictionary<string, ICar> cars;

        public CarRepository()
        {
            cars = new Dictionary<string, ICar>();
        }

        public void Add(ICar model)
        {         

            if (cars.ContainsKey(model.Model))
            {
                throw new ArgumentException($"Car {model.Model} is already created.");
            }
            cars.Add(model.Model, model);
        }

        public IReadOnlyCollection<ICar> GetAll()
        {
            return cars.Values.ToList();
        }

        public ICar GetByName(string name)
        {
            ICar car = null;

            if (cars.ContainsKey(name))
            {
                car = cars[name];
            }

            return car;
        }

        public bool Remove(ICar model)
        {
            return cars.Remove(model.Model);
        }
    }
}
