using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    // Why use a struct over a class. You cannot create a constructor in structs.  Structs do not support
    // inheritance.  You can have a private or public struct. 

    // posted by Scott Smith | 2/2/2011 4:22:24 PM
    // Reference Type vs.Value Type:
    // One of the primary differences between a Class and a Struct is that a Class is a reference type 
    // and a Struct is a value type.What does this mean? Well, let's take a look at other value types. 
    // All of the primitive types such as int, bool, decimal etc. are value types. Value types are stored 
    // in the stack as a single space in memory whereas refernce types are created in memory and a reference 
    // to that space is also create. The reference type is always accessed via the reference and not directly. 
    // For example;

    //      Point p1 = new Point();       //Point is a Struct
    //      Form f1 = new Form();       //Form is a Class

    //      Point p2 = p1;
    //        Form f2 = f1;

    // In the above code example p2 is an independent copy of p1.If you were to change a value of a property 
    // of p2, p1 would not be affected.Whereas f2 is a copy of the refence to f1 there for f1 and f2 are both 
    // references to the same object in memory.If you were to change a value of a property of f2, f1 would 
    // also be changed.

    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public void Display()
        {
            Console.WriteLine("Game 1's name is: {0}", name);
            Console.WriteLine("Game 1's developer is: {0}", developer);
            Console.WriteLine("Game 1's rating is: {0}", rating);
            Console.WriteLine("Game 1's was released in: {0}", releaseDate);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game game1;

            game1.name = "Call of Duty";
            game1.developer = "Activision";
            game1.rating = 3.5;
            game1.releaseDate = "10.29.2003";

            game1.Display();

            Console.ReadKey(true);
        }
    }
}
