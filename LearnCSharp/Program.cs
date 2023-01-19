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
            Console.WriteLine("Uppercase: " + greeting.ToUpper());
            Console.WriteLine("Lowercase: " + greeting.ToLower());
        }
    }
}
