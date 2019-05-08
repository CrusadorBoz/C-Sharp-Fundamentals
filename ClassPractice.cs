using System;

namespace practiceClass
{

    class Animal
    {
        // private, public, static
        // Default - Private can only be accessed in the same class
        // Public you can access by calling the class.
        // Static can be accessed by all other instances.

        // Class Variables:
        public static int count = 0;

        private readonly string name;   // now in constructor = "Spotty";  // Cannot be accessed outside calls.
        public int age;                 // = 0;
        public float happiness;         // = 0.5f;

        // This is a Constructor Class
        public Animal ()
        {
            name = "Spotty";
            age = 6;
            happiness = 0.5f;

            count++;
        }

        public Animal( string _name, int _age, float _happiness )
        {
            name = _name;
            age = _age;
            happiness = _happiness;

            count++;
        }

        // Class Methods
        // Access modifiers are protection level.
        public void Print()  // Method must begin with upper case!
        {
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("Age: {0}", this.age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class.
            Animal dog = new Animal();
            int dAge = dog.age;
            Console.WriteLine(dAge);

            Animal dog2 = new Animal();
            dog2.Print();

            // Using a different constructor for animal.
            Animal cat = new Animal("New Dog Spotty", 14, 0.8f);
            cat.Print();

            Console.WriteLine();
            Console.WriteLine("Num of Animals: {0}", Animal.count);

            // error Console.WriteLine(dog.name);
            dog.age = 23;  // This works it is not private
            Console.WriteLine(dog.age);  // This works it is not private
            // error dog.name = "Test";
            dog.Print();
            Console.ReadKey();
        }
    }
}
