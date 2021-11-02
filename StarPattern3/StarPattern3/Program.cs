using System;

namespace StarPattern3
{
    //pyramid pattern
    class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            for (int i = 1; i <= num; i++)
            {
                for (int j = num; j> i; j--)
                {
                    Console.Write(" ");
                }

                for (int k=1;k<=i;k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
