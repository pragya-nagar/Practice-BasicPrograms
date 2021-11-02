using System;

namespace FactorialRecursion
{
    public class Program
    {
        public static long GetFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * GetFactorial(number - 1);
            }
        }
        static void Main(string[] args)
        {
            long fact = GetFactorial(3);
            Console.WriteLine("{0} factorial is {1}", 3, fact);
            Console.ReadKey();
        }
    }
}
