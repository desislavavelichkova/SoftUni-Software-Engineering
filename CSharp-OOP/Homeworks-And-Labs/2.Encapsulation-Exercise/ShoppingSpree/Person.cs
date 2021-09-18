using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private List<Product> products;
       
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            products = new List<Product>();           
            
        }
        public string Name 
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public double Money 
        {
            get => this.money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }  
        public void AddProduct(Product product)
        {
            if (product.Cost > Money)
            {
                throw new InvalidOperationException($"{ Name} can't afford {product.NameOfProduct}");
            }
            products.Add(product);
            Money -= product.Cost;
        }

        public override string ToString()
        {
            if (products.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }
            return $"{Name} - {string.Join(", ",products.Select(p => p.NameOfProduct))}";
        }
    }
}
