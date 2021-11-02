using System;

namespace SumOfDigitsRecursion
{
    class Program
    {
        /// <summary>
        /// if denominator is greator than numerator than modulus result is numerator 
        /// If integer is divided by integer than result will be integer if you want floating point no. then you have to cast particular no.
        /// Jb dusri baar sum method chlegi to uska result 2 aayega to ese 3 + 2 = 5 ho jaayega
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int sum(int num)
        {
            if (num != 0)
            {
                return (num % 10 + sum(num / 10));
            }
            else
                return 0;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            int result = program.sum(23);
            Console.WriteLine("{0} sum is {1}", 23, result);
            Console.ReadKey();
        }
    }
}
