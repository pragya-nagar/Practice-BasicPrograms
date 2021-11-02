using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3;
            var number = 10;
            Console.Write(n1 + " " + n2 + " ");
            for (int i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3+" ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
