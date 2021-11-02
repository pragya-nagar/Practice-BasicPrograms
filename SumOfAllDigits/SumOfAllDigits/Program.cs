using System;

namespace SumOfAllDigits
{
    class Program
    {

        //divide by 10 aakri ka number uda deta hai and mod 10 aakhri ka number return krta h
        internal static void SumOfDigits(int number)
        {
            int sum = 0;
            while(number>0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            SumOfDigits(28);
        }
    }
}
