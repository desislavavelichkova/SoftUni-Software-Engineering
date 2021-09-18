using AquaShop.Models.Decorations.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Repositories.Contracts
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        public List<IDecoration> decorations;

        public DecorationRepository()
        {
            this.decorations = new List<IDecoration>();
        }

        public IReadOnlyCollection<IDecoration> Models => decorations;

        public void Add(IDecoration model)
        {
            this.decorations.Add(model);
        }

        public IDecoration FindByType(string type)
        {
            var currentDecoration = decorations.FirstOrDefault(x => x.GetType().Name == type);

            return currentDecoration;
        }

        public bool Remove(IDecoration model)
        {
            if (decorations.Any(p => p.GetType().Name == model.GetType().Name))
            {
                decorations.Remove(model);
                return true;

            }
            return false;
        }
    }
}
