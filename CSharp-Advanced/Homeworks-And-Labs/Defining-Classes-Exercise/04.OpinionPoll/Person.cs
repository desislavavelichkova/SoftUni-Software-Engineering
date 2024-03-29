﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {             
        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }
        
        public Person(int age)
            : this()
        { 
            this.Age = age; 
        }
        public Person(string name) : this()
        {
            this.Name = name;
        }
        public Person (string name, int age): this()
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        
    }
}
