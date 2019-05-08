using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // int counter = 15;
            int lengthOfText = 0;
            string wholeText = "";

            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfAFriend + (" ");

                // Console.WriteLine(counter);
                // counter++;  // It is important to have the counter or you can get an infinite loop.
            }
            while (lengthOfText < 10);
            Console.WriteLine("Thanks, that was enough! " + wholeText);
            Console.ReadKey(true);
        }
    }
}
