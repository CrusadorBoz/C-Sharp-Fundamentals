using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the first number you would like to add: ");
            string firstNum = Console.ReadLine();
            Console.WriteLine("What is the second number you would like to add: ");
            string secondNum = Console.ReadLine();

            int num3 = Int32.Parse(firstNum);
            int num4 = Int32.Parse(secondNum);
            int num5 = Add(num3, num4);
            Console.WriteLine("The sum of " + firstNum + "+" + secondNum + " = " + num5);

            //string gorString = "15";
            //string mySecondString = "13";
            //int num3 = Int32.Parse(gorString);
            //int num4 = Int32.Parse(mySecondString);
            //int resultInt = num3 + num4;
            //Console.WriteLine(resultInt);

            Console.ReadKey(true);

            //string input = Console.ReadLine();
            //Console.WriteLine(input);
            //Console.Read();

            //string friend1 = "Frank";
            //string friend2 = "Michael";
            //string friend3 = "Wlad";

            //GreetFriend(friend1);
            //GreetFriend(friend2);
            //GreetFriend(friend3);
            //Console.Write("\n");

            //GreetFriends(friend1, friend2);

            //Console.ReadKey(true);

            //WriteSomething();
            //WriteSomethingSpecific("I am an argument that is called form a method");
            //int result = Add(3, 4);
            //Console.WriteLine(result);
            //Console.WriteLine(Add(5, 8));
            //Console.WriteLine(Add(Add(1, 2), Add(4, 50)));
            //Console.WriteLine(Multiply(25, 25));
            //Console.WriteLine(Divide(53, 9));
        }

        //public static void WriteSomething()
        //{
        //    Console.WriteLine("I am called from a Method!\n");
        //}

        //public static void WriteSomethingSpecific(string myText)
        //{
        //    Console.WriteLine(myText);
        //}

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        //public static double Multiply(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        //public static double Divide(double num1, double num2)
        //{
        //    return num1 / num2;
        //}

        //public static void GreetFriend(string friendname)
        //{
        //    Console.WriteLine("Hi, " + friendname + " my friend");
        //}

        //public static void GreetFriends(string friendname, string friendname2)
        //{
        //    Console.WriteLine("Hi, " + friendname + " my friend");
        //    Console.WriteLine("Hi, " + friendname2 + " my friend");
        //}
    }
}
