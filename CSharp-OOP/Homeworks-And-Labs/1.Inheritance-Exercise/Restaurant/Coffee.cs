using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double CaffeMilliliters = 50;
        private const decimal CoffeePrice = (decimal)3.50;
        public Coffee(string name, double caffeine)
            : base (name, CoffeePrice, CaffeMilliliters)
        {
            Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
       
    }
}
