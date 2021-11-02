using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while(number>0)
            {
                int reminder = number % 10;
                Reverse = (Reverse * 10) + reminder;
                number = number / 10;
            }
            Console.WriteLine("Reverse no. is" + " " + Reverse);
            Console.ReadKey();

        }
    }
}
