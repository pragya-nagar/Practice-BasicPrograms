using System;

namespace ParamsKeyword
{
    class Program
    {
        void Show(params int[] val)
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Show(1, 56, 78, 89, 23, 98, 56, 77);//passing arguments of variable length
            Console.ReadKey();
        }
    }
}
