﻿using LINQ.App.ENUM;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.App.Entities
{
    public class Dog
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Race Race { get; set; }

        public Dog(string name, string color, int age, Race race)
        {
            Name = name;
            Color = color;
            Age = age;
            Race = race;
        }

    }
}
