using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    internal class Animal
    {
        public string name = "cow";
        public int numberOfLegs = 4;

        public void Introduce()
        {
            Console.WriteLine($"I am a {name} and I have {numberOfLegs} legs.");
        }
    }
}
