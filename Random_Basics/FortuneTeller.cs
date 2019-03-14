using System;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease enter a question you want answered!");
            Console.ReadLine();

            Random fortuneYesNoMaybe = new Random();
            int fortuneAnswer;
            fortuneAnswer = fortuneYesNoMaybe.Next(1, 4);
            if(fortuneAnswer == 1)
            {
                Console.WriteLine("Yes");
            }else if (fortuneAnswer == 2)
            {
                Console.WriteLine("Maybe");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadKey(true);
        }
    }
}
