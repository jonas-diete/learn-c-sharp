using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    internal class Animal
    {
        // defining the variables - name can be accessed outside of the class (public),
        // whereas numberOfLegs just from within (private)
        public string name;
        private int numberOfLegs;

        // this is the constructor - it has to be the same name as the class and return nothing
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
