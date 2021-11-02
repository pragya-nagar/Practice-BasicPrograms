using System;

namespace SumOfTwoNumbers
{
    //Addition of two numbers without using + operator
    class Program
    {
        static void Main(string[] args)
        {
            Add(3, 2);
        }

        public static void Add(int a , int b)
        {
            Console.WriteLine(a-(-b));
        }
    }
}
