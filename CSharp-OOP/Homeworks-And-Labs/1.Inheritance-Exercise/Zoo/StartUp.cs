﻿using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Bear bear = new Bear(name);
            Gorilla gorilla = new Gorilla(name);
            Lizard lizard = new Lizard(name);
            Snake snake = new Snake(name);
        }
    }
}