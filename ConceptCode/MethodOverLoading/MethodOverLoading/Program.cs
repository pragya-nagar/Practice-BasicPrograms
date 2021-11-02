using System;

namespace MethodOverLoading
{
    public class Cal
    {
        /// <summary>
        /// Same method overloading can be done by changing the type of parameters
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(12, 12));
            Console.WriteLine(Add(12, 12, 12));
        }
    }
    
}
