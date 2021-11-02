using System;

namespace StarPattern4
{
    //    *
    //   **
    //  ***
    // ****
    //*****
    class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            int i, j, k;
            for(i=1;i<=num;i++)
            {
                for(j=1;j<=num-i;j++)
                {
                    Console.Write(" ");
                    
                }

                for (k=1;k<=i;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
