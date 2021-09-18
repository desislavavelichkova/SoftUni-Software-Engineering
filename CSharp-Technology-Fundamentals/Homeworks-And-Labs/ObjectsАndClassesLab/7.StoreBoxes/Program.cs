using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StoreBoxes
{
    public class Box
    {                 
        public string SerialNumber { get; set; }        
        public Item Item { get; set; }    
        public int ItemQuantity { get; set; }
        public double PriceForBox { get; set; }
    }

    public class Item
    {
        public string ItemName { get; set; }
        public double Price { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Box> boxes = new List<Box>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] receivingData = input.Split(" ");

                string serialNumber = receivingData[0];
                string itemName = receivingData[1];
                int itemQuantity = int.Parse(receivingData[2]);
                double itemPrice = double.Parse(receivingData[3]);
                double priceForBox = itemQuantity * itemPrice;

            Box box = new Box();
            box.SerialNumber = serialNumber;
            box.ItemQuantity = itemQuantity;
            box.PriceForBox = priceForBox;
            box.Item = new Item()
            { 
                ItemName = itemName,
                Price = itemPrice
            };    

                boxes.Add(box);
                input = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(x => x.PriceForBox).ToList();

            foreach (Box box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.ItemName} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }

        }
    }

}
