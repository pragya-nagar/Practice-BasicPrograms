using System;

namespace IfElseExampleWithEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var number = Convert.ToInt32(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine("It is an even number");
            }
            else
            {
                Console.WriteLine("It is an odd number");
            }
        }
    }
}
