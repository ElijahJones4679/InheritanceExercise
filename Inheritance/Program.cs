using System;
using System.Xml.Linq;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var myBird = new Bird();
            myBird.ColorWings = "blue";
            myBird.BeakLength = 3.5;
            myBird.CanFly = true;
            myBird.Name = "Blueberry";
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "Swamp",
                CanGrowTail = true,
            };
            var myAnimals = new Animal[] {myBird, lizard};

            foreach(var animal in myAnimals) 
            {
                Console.WriteLine($"type: {animal}");
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age:{animal.Age} years old");
                Console.WriteLine($"It name:{animal.Name}");
                Console.WriteLine($"Its height is:{animal.Height} inches tall");



            }

        }
    }
}
