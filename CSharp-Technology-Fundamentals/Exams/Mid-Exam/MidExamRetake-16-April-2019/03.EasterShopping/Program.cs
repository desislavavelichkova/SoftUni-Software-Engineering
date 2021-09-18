using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.EasterShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .ToList();

            int numberOfCommands = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] cmndsArg = input.Split(" ").ToArray();

                string command = cmndsArg[0];

                if (command == "Include")
                {
                    string shopName = cmndsArg[1];
                    shops.Add(shopName);
                }

                else if (command == "Visit")
                {
                    string firstOrLast = cmndsArg[1];
                    int numberOfShops = int.Parse(cmndsArg[2]);

                    if (shops.Count >= numberOfShops)
                    {
                        if (firstOrLast == "first")
                        {
                            for (int j = 0; j < numberOfShops; j++)
                            {
                                shops.RemoveAt(0);
                            }
                        }
                        else if (firstOrLast == "last")
                        {
                            for (int j = numberOfShops - 1; j >= 0; j--)
                            {
                                shops.RemoveAt(shops.Count - 1);
                            }
                        }
                    }
                }

                else if (command == "Prefer")
                {
                    int firstShopIndex = int.Parse(cmndsArg[1]);
                    int secondShopIndex = int.Parse(cmndsArg[2]);

                    if (firstShopIndex >= 0 && firstShopIndex <= shops.Count - 1 && secondShopIndex >= 0 && secondShopIndex <= shops.Count - 1)
                    {
                        string temp1 = shops[firstShopIndex];
                        string temp2 = shops[secondShopIndex];
                        shops[firstShopIndex] = temp2;
                        shops[secondShopIndex] = temp1;
                    }
                }

                else if (command == "Place")
                {
                    string newShopName = cmndsArg[1];
                    int newShopIndex = int.Parse(cmndsArg[2]);

                    if (newShopIndex >= 0 && newShopIndex <= shops.Count)
                    {
                        shops.Insert(newShopIndex + 1, newShopName);
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shops));
        }
    }
}
