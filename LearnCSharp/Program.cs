using System;

namespace LearnCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // testing variables
            Console.WriteLine("Hello and welcome!");
            int age = 21;
            const string MonthOfBirth = "October";
            Console.WriteLine("You are " + age + " years old.");
            Console.WriteLine("You were born in " + MonthOfBirth + ".");

            // Testing some maths
            Console.WriteLine("5 / 2 = " + 5 / 2);
            Console.WriteLine("5.0 / 2 = " + 5.0 / 2);

            // multiple variables
            int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);
        }
    }
}
