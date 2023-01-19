using System;
using System.Data;

namespace LearnCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // testing variables
            Console.WriteLine("Hello and welcome!");
            int age = 21;
            const string monthOfBirth = "October";
            Console.WriteLine("You are " + age + " years old.");
            Console.WriteLine("You were born in " + monthOfBirth + ".");

            // Testing some maths
            Console.WriteLine("5 / 2 = " + 5 / 2);
            Console.WriteLine("5.0 / 2 = " + 5.0D / 2);

            // multiple variables
            int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);

            // arithmetic and logical operators are the same as in JavaScript, which I know already.
            // + - * / %
            // || && !

            // user input
            Console.WriteLine("Please enter your height in cm: ");
            int heightInCm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your height is " + heightInCm + "cm.");
            heightInCm++;
            Console.WriteLine("It appears you have grown by 1cm. Your new height is " + heightInCm + "cm.");

            // math functions
            int largestHeight = Math.Max(141, 125);
            Console.WriteLine(largestHeight + "cm is the largest height.");
            int shortestHeight = Math.Min(141, 125);
            Console.WriteLine(shortestHeight + "cm is the shortest height.");

            // string functions
            Console.Write("Write a greeting: ");
            string greeting = Console.ReadLine();
            Console.WriteLine("Your greeting is " + greeting.Length + " characters long.");
            Console.WriteLine($"Uppercase: {greeting.ToUpper()} - amazing isn't it?");
            Console.WriteLine($"Lowercase: {greeting.ToLower()} - and all small!");

            string name = "James Bond";
            int firstLetterSurnameCharPosition = name.IndexOf("B");
            // Substring creates a new string starting at that index position
            string lastName = name.Substring(firstLetterSurnameCharPosition);
            Console.WriteLine(lastName);

            // escaping - works for \ ' "
            string statement = "Most \"Cavemen\" didn't actually live in caves";
            Console.WriteLine(statement);

            // if statements
            bool light = true;
            if (light)
            {
                Console.WriteLine("It's light!");
            }

            Console.WriteLine("Write the time in hours (24 hours max).");
            int time = Convert.ToInt32(Console.ReadLine());
            if (time > 5 && time < 12)
            {
                Console.WriteLine("It's the morning!");
            }
            else if (time < 14)
            {
                Console.WriteLine("It's lunchtime!");
            }
            else if (time < 18)
            {
                Console.WriteLine("It's the afternoon.");
            }
            else if (time < 22)
            {
                Console.WriteLine("It's the evening.");
            }
            else
            {
                Console.WriteLine("It's nighttime.");
            }

            // loops
            for (int i = 0; i < 21; i += 2)
            {
                Console.WriteLine(i);
            }

            string[] countries = { "United Kingdom", "Nigeria", "Laos", "Canada", "Bolivia" };
            foreach (string country in countries) 
            {
                Console.WriteLine(country);
            }
        }
    }
}
