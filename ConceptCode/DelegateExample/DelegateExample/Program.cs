using System;

namespace DelegateExample
{
    delegate int Calculator(int n); //declaring delegate

    class Program
    {
        static int number = 100;

        public static int add(int n)
        {
            number = number + n;
            return number;
        }

        public static int mul(int n)
        {
            number = number * n;
            return number;

        }

        public static int GetNumber()
        {
            return number;
        }
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator(add);//instantiating delegate
            Calculator c2 = new Calculator(mul);
            c1(20); // calling method using delegate
            Console.WriteLine("After c2 delegate number is " + GetNumber());
            c2(3);
            Console.WriteLine("After c2 delegate, Numebr is " + GetNumber());

        }
    }
}
