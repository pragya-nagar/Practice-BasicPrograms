using System;

namespace JoinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //This join method below will separate the elements with space
            object[] array = { "Hello", "1234", "Geeks", 78545 };
            string s1 = string.Join(",", array);
            Console.WriteLine(s1);
            Console.ReadKey();
        }
    }
}
