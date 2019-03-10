using System;

namespace Arrays
{
    class Program
    {
        public static int maxScore(int[] numbers)
        {
            int maxTracker = numbers[0];
            // for each loop  
            foreach (int grade in numbers)
            {
                if (grade > maxTracker)
                    { maxTracker = grade; }
            }
            return maxTracker;
        }

        static void Main(string[] args)
        {
            // First way to create an array:
            int[] scores = new int[5];

            scores[0] = 97;
            scores[1] = 100;
            scores[2] = 87;
            scores[3] = 92;
            scores[4] = 85;

            Console.WriteLine("Grades at index 0 : {0}", scores[0]);


            // Assign value to array grades at index 0
            Console.WriteLine("Enter Grade for first array spot");
            string input = Console.ReadLine();
            scores[0] = int.Parse(input);
            Console.WriteLine("Grades at index 0 : {0}", scores[0]);

            // Second way of creating an array
            int[] Tom = { 90, 92, 87, 75, 97 };
            // If you want to find the highest value in the array.  Use a method:
            int tomHighScore = maxScore(Tom);
            Console.WriteLine("Tom's High Score: {0}", tomHighScore);

            // Third way of creating an array
            int[] Charlie = new int[] { 100, 75, 85, 77, 65, 50 };
            int highScore = maxScore(Charlie);
            Console.WriteLine("\nCharlie's High Score on his test: {0}", highScore);

            Console.WriteLine("\nNumber of tests Charlie took: {0}", Charlie.Length);
            int counter = 1;
            // Foreach loops are not appropriate if you want to update an array.  It would only work with the grade variable.  Does not track index.  Put in counter.
            foreach (int grade in Charlie)
            {
                Console.WriteLine("Test" + counter + ": {0}", grade);
                counter++;
            }
            Console.ReadKey(true);
        }
    }
}
