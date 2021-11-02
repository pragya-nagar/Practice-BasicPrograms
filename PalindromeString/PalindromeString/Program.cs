using System;

namespace PalindromeString
{
    class Program
    {
        internal void PalindromeString(string s)
        {
            string rev=" ";
            // Console.WriteLine("Please enter your string");
          //  Console.ReadKey();
           // s = Console.ReadLine();
            for (var i = s.Length-1 ; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            if (rev.Equals(s))
            {
                Console.WriteLine("String is Palindrome");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("String is not Palindrome");
                Console.ReadKey();
            }

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.PalindromeString("madam");
        }
    }
}
