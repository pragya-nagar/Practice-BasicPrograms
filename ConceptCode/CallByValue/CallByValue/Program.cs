using System;

namespace CallByValue
{
    class Program
    {
        /// <summary>
        /// In call by value a copy of the variable is passed
        /// </summary>
        /// <param name="val"></param>
        public void show(int val)
        {
            val *= val;
            Console.WriteLine("Value inside the function" + val);
        }
        static void Main(string[] args)
        {
            int val = 5;
            Program program = new Program();
            Console.WriteLine("Value before calling the function" + val);
            program.show(val);
            Console.WriteLine("Value after callin the function" + val);
            Console.ReadKey();

        }
    }
}
