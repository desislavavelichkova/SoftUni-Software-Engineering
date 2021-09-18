using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using AquaShop.Repositories.Contracts;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private List<IAquarium> aquariums;
        private DecorationRepository decorationRepository;
        

        public Controller()
        {
            this.aquariums = new List<IAquarium>();
            this.decorationRepository = new DecorationRepository();            
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
                             

            if (aquariumType == nameof(FreshwaterAquarium))
            {
                IAquarium aquarium = new FreshwaterAquarium(aquariumName);
                aquariums.Add(aquarium);
            }
            else if (aquariumType == nameof(SaltwaterAquarium))
            {
                IAquarium aquarium = new SaltwaterAquarium(aquariumName);
                aquariums.Add(aquarium);
            }
            else
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidAquariumType));
            }           

            return string.Format(OutputMessages.SuccessfullyAdded, aquariumType);
        }

        public string AddDecoration(string decorationType)
        {
                        

            if (decorationType == nameof(Ornament))
            {
               IDecoration decoration = new Ornament();
                decorationRepository.Add(decoration);                
            }
            else if (decorationType == nameof(Plant))
            {
                IDecoration decoration = new Plant();
                decorationRepository.Add(decoration);                
            }
            else
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidDecorationType));
            }
            
            return string.Format(OutputMessages.SuccessfullyAdded, decorationType);
        }
       
        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            var currentAquarium = aquariums.FirstOrDefault(x => x.Name == aquariumName);
                        
            if (fishType == nameof(FreshwaterFish))
            {
                if (currentAquarium.GetType().Name == nameof(FreshwaterAquarium))
                {
                    IFish fish = new FreshwaterFish(fishName, fishSpecies, price);
                    currentAquarium.AddFish(fish);
                }
                else
                {
                    return string.Format(OutputMessages.UnsuitableWater);
                }
            }
            else if (fishType == nameof(SaltwaterFish))
            {
                if (currentAquarium.GetType().Name == nameof(SaltwaterAquarium))
                {
                    var fish = new SaltwaterFish(fishName, fishSpecies, price);
                    currentAquarium.AddFish(fish);
                }
                else
                {
                    return string.Format(OutputMessages.UnsuitableWater);
                }
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }
            
            return string.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName );
        }

        public string CalculateValue(string aquariumName)
        {
            var currentAquarium = aquariums.FirstOrDefault(x => x.Name == aquariumName);

            var sumOfFishes = currentAquarium.Fish.Sum(x => x.Price);
            var sumOfDecorations = currentAquarium.Decorations.Sum(x => x.Price);
            var total = sumOfFishes + sumOfDecorations;

            return string.Format(OutputMessages.AquariumValue, aquariumName, total);
        }

        public string FeedFish(string aquariumName)
        {
            var currentAquarium = aquariums.FirstOrDefault(x => x.Name == aquariumName);
            
            foreach (var fish in currentAquarium.Fish)
            {
                fish.Eat();                
            }            

            return string.Format(OutputMessages.FishFed, currentAquarium.Fish.Count);

        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            var findDecoration = decorationRepository.FindByType(decorationType);
            var currentAquarium = aquariums.FirstOrDefault(x => x.Name == aquariumName);

            if (findDecoration == null)
            {
                throw new InvalidOperationException($"There isn't a decoration of type {decorationType}.");
            }
            else
            {
                decorationRepository.Remove(findDecoration);
                currentAquarium.AddDecoration((IDecoration)findDecoration);
            }
            return string.Format(OutputMessages.EntityAddedToAquarium, decorationType, aquariumName);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var aquarium in aquariums)
            {
                sb.AppendLine(aquarium.GetInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
