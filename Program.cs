using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 15;

            switch (age)
            {
                case 15:
                    Console.WriteLine("To young to party in the club");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            if (age == 15)
            {
                Console.WriteLine("Too young to party in the club!");
            }
            else if (age == 25)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }

            string username = "root";

            switch (username)
            {
                case "gordon":
                    Console.WriteLine("Username is Boz");
                    break;
                case "root":
                    Console.WriteLine("Username is root");
                    break;
                default:
                    Console.WriteLine("Username is unknown");
                    break;
            }
            Console.ReadKey(true);
        }
    }
}
