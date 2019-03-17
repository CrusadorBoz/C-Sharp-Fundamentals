using System;
using System.Text.RegularExpressions;

namespace RegexEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program using regular expressions to find email address in a body of text.
            string data = "This is my email, MyEmail@gmail.com and my brother's email is Bro@gmail.com";

            Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.IgnoreCase);
            MatchCollection emailMatches = emailRegex.Matches(data);

            foreach (Match emailMatch in emailMatches)
            {
                Console.WriteLine(emailMatch.Value);
            }
            Console.ReadKey(true);
        }
    }
}
