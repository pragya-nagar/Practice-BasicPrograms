using System;

namespace PalindromeNumber
{
    class Program
    {

        //Get the number from user
        //Hold the number in temporary variable
        //Reverse the number
        //Compare the temporary number with reversed number
        //If both numbers are same, print palindrome number
        //Else print not palindrome number
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter the numebr");
          //  n = int.Parse(Console.ReadLine());
          n = 101;
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("Number is Palindrome");
            }
            else
            {
                Console.WriteLine("Number is not a  Palindrome");
            }
        }
    }
}
