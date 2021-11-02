using System;

namespace CallByReference
{
    class Program
    {
        /// <summary>
        /// In call by Reference instead of copy of variable a varible itself is passed
        /// </summary>
        /// <param name="val"></param>
        public void Show(ref int val)
        {
            val *= val;
            Console.WriteLine("Value inside the method" + " " + val);
        }
        static void Main(string[] args)
        {
            int value = 2;
            Program program = new Program();
            Console.WriteLine("Value before calling the function" + " " + value);
            program.Show(ref value);
            Console.WriteLine("Value after calling the function" + " " + value);
            Console.ReadKey();
             
        }
    }
}
