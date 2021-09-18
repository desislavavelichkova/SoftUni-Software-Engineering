using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        private string nameOfProduct;
        private double cost;

        public Product(string nameOfProduct, double cost)
        {
            NameOfProduct = nameOfProduct;
            Cost = cost;
        }

        public string NameOfProduct
        {
            get => this.nameOfProduct;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                nameOfProduct = value;
            }
        }

        public double Cost 
        {
            get => this.cost;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                cost = value;
            }
        }
    }
}
