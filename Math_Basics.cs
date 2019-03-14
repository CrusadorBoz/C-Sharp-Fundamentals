using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling: " + Math.Ceiling(15.3));
            Console.WriteLine("Floor: " + Math.Floor(15.3));

            int num1 = 13;
            int num2 = 9;

            Console.WriteLine("Lower of Num1 {0} and Num2 {1} is {2}", num1, num2, Math.Min(num1,num2));
            Console.WriteLine("Higher of Num1 {0} and Num2 {1} is {2}", num1, num2, Math.Max(num1, num2));

            Console.WriteLine("3 to the power of 5 is {0}", Math.Pow(3,5));

            Console.WriteLine("PI is: {0}", Math.PI);

            Console.WriteLine("The Square root of 25 is {0}:", Math.Sqrt(25));

            Console.WriteLine("Always Positive is {0}:", Math.Abs(-25));

            Console.WriteLine("COS of 1 is: {0}:", Math.Cos(1));

            Console.ReadKey(true);
        }
    }
} 
