using System;
using System.Linq;

namespace LearnCSharp
{
    internal class Program
    {
        static void VariableLearning()
        {
            // Learning about Variables
            Console.WriteLine("Hello and welcome!");
            int age = 21;
            const string monthOfBirth = "October";
            Console.WriteLine("You are " + age + " years old.");
            Console.WriteLine("You were born in " + monthOfBirth + ".");
        }

        static void MathsLearning()
        {
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
        }

        static void UserInputLearning()
        {
            // learning to take user input
            Console.WriteLine("Please enter your height in cm: ");
            int heightInCm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your height is " + heightInCm + "cm.");
            heightInCm++;
            Console.WriteLine("It appears you have grown by 1cm. Your new height is " + heightInCm + "cm.");
        }

        static void MathsFunctionsLearning()
        {
            // Learning about Maths Functions
            int largestHeight = Math.Max(141, 125);
            Console.WriteLine(largestHeight + "cm is the largest height.");
            int shortestHeight = Math.Min(141, 125);
            Console.WriteLine(shortestHeight + "cm is the shortest height.");
        }

        static void StringFunctionsLearning()
        {
            // Learning about string functions
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
        }

        static void IsItLight(bool light)
        {
            // practising bool and if statements
            if (light)
            {
                Console.WriteLine("It's light!");
            }
            else
            {
                Console.WriteLine("It's dark!");
            }
        }

        static void TimeOfDay()
        {
            Console.WriteLine("Write the time in hours (24 hours max).");
            int time = Convert.ToInt32(Console.ReadLine());
            if (time > 5)
            {
                if (time < 12)
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
                else if (time < 23)
                {
                    Console.WriteLine("It's the evening.");
                }
                else
                {
                    Console.WriteLine("It's nighttime");
                }
            }
            else
            {
                Console.WriteLine("It's nighttime.");
            }
        }

        static void ForLoopLearning()
        {
            for (int i = 0; i < 21; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        static void DisplayCountries()
        {
            // practising foreach loop
            string[] countries = { "United Kingdom", "Nigeria", "Laos", "Canada", "Bolivia" };
            foreach (string country in countries)
            {
                Console.WriteLine(country);
            }
        }

        static void ChangingArrays()
        {
            // practising how to change arrays
            int[] lovelyNumbers = { 23, 13, 5, 12, 7 };

            Console.WriteLine("Third index of array: " + lovelyNumbers[3]);
            Console.WriteLine("Changing third index...");
            lovelyNumbers[3] = 3;
            Console.WriteLine("Third index of array: " + lovelyNumbers[3]);

            Console.WriteLine("Sorting array...");
            Array.Sort(lovelyNumbers);
            foreach (int number in lovelyNumbers)
            {
                Console.WriteLine(number);
            }
        }

        static void ArrayFunctions()
        {
            int[] lovelyNumbers = { 23, 13, 5, 12, 7 };
            // these functions use System.Linq
            Console.WriteLine("Largest lovely number: " + lovelyNumbers.Max());
            Console.WriteLine("Smallest lovely number: " + lovelyNumbers.Min());
            Console.WriteLine("Sum of lovely numbers: " + lovelyNumbers.Sum());
        }

        static void Learning2DArrays()
        {
            // 2D arrays - declare with comma!
            int[,] my2DArray = { { 2, 4, 6 }, { 3, 4, 10 } };
            Console.WriteLine("second array, third element: " + my2DArray[1, 2]);
            Console.WriteLine("first array, third element: " + my2DArray[0, 2]);
        }

        static string CreateIntroduction(string name, int age)
        {
            return $"Hello, my name is {name} and I am {age} years old.";
        }

        static int SumFromOneUntil(int lastNumber)
        {
            int result = 0;
            for (int i = 0; i <= lastNumber; i++)
            {
                result += i;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CreateIntroduction("Timothy", 23));
            Console.WriteLine(CreateIntroduction("Barbara", 57));
            Console.WriteLine(CreateIntroduction("Richard", 74));

            Console.WriteLine(SumFromOneUntil(100));

            Animal animal = new Animal();
            Console.WriteLine(animal.name);
            Console.WriteLine(animal.numberOfLegs);
        }
    }
}
