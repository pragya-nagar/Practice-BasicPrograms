using System;
using System.Threading;

namespace NumberToCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, r;
            Console.WriteLine("Enter a Number");
            n = int.Parse(Console.ReadLine());
            //while (n>0)
            //{
            //    r = n % 10;
            //    sum = sum * 10 + r;
            //    n = n / 10;

            //}

            //n = sum;
            while (n>0)
            {
                r = n % 10;
                switch (r)
                {
                    case 1: 
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    default:
                        Console.WriteLine("NA");
                        break;
                }

                n = n / 10;
            }
        }
    }
}
