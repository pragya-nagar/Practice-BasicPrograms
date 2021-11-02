using System;

namespace SwapWithoutTempVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine("Before swap a=" + a + "and b=" + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("Values of a and b are {0} and {1}", a , b);
        }
    }
}
