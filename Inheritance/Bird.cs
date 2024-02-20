using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class

    {
        public Bird() 
        {
            IsAlive = true;
            Age = 2;
            Height = 5.7;
            Name = "Cherry";

        }
        public string ColorWings { get; set; }  
        public double BeakLength { get; set; }
        public bool CanFly { get; set; }
        public bool Wings { get; set; }
    }
}
