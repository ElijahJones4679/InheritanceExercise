﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class

    {
        public Reptile() 
        {
            IsAlive = true;
            Age = 5;
            Name = "Slither";
            Height = 83;
        }
        public bool IsColdBlooded { get; set; }
        public bool IsScaly { get; set; }
        public string Habitat { get; set; }
        public bool CanGrowTail { get; set; }
    }
}
