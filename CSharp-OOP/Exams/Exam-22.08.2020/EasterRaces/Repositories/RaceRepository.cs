using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Repositories
{
    public class RaceRepository : IRepository<IRace>
    {
        private readonly IDictionary<string, IRace> races;

        public RaceRepository()
        {
            races = new Dictionary<string, IRace>();
        }

        public void Add(IRace model)
        {
            if (races.ContainsKey(model.Name))
            {
                throw new ArgumentException($"Race {model.Name} is already created.");
            }

            races.Add(model.Name, model);
        }

        public IReadOnlyCollection<IRace> GetAll()
        {
            return (IReadOnlyCollection<IRace>)this.races.Values.ToList();
        }

        public IRace GetByName(string name)
        {
            IRace race = null;

            if (races.ContainsKey(name))
            {
                race = races[name];
            }

            return race;
        }


        public bool Remove(IRace model)
        {            
            return races.Remove(model.Name); 
        }
    }
}
