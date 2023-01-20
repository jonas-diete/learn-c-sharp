using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    internal class Animal
    {
        // defining the variables
        public string name;
        public int numberOfLegs;

        // this is the constructor
        public Animal(string animalName, int animalNumberOfLegs)
        {
            name = animalName;
            numberOfLegs = animalNumberOfLegs;
        }

        // this is another method
        public void Introduce()
        {
            Console.WriteLine($"I am a {name} and I have {numberOfLegs} legs.");
        }
    }
}
