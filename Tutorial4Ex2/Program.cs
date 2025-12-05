using System;

namespace Tutorial4Ex2
{
    // This is the Person class
    public class Person
    {
        public string Name;
        public int Age;

        // Constructor to set name and age
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    // This is the Program class with Main method
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of Person
            Person person1 = new Person("Diwash", 22);

            // Print values
            Console.WriteLine("Person Information:");
            Console.Writeliine("THIS IS THE UPDATED VERSION AFTER MAKEING SOME CHANGES.")
            Console.WriteLine("Name: " + person1.Name);
            Console.WriteLine("Age: " + person1.Age);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

