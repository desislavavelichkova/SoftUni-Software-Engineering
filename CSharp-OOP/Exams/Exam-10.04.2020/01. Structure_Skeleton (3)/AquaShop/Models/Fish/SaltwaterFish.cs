using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Fish
{
    public class SaltwaterFish : Fish
    {        
        private static int size = 5;
        private const int sizeConst = 2;
        
        public SaltwaterFish(string name, string species, decimal price) 
            : base(name, species, price)
        {
            
        }
        public override void Eat()
        {
            size += sizeConst;
        }
    }
}
