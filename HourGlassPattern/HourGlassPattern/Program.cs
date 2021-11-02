using System;

namespace HourGlassPattern
{
    class Program
    {
        static void pattern(int rows_no)
        {
            int i, j, k;
            //for loop for printing upper half
            for (i = 1; i <= rows_no; i++)
            {
                //Printing i spaces at the beginning off each row
                for (k = 1; k < i; k++)

                    Console.Write(" ");
                //printing i to rows value at the end of each row
                for (j = i; j <= rows_no; j++)
                    Console.Write(j + " ");
                Console.WriteLine();
            }

            //For loop for printing lower half
            for (i = rows_no - 1; i >= 1; i--)
            {
                //Printing i spaces at the beginning off each row
                for (k = 1; k <= i; k++)
                    Console.Write(" ");
                //printing i to rows value at the end of each row
                for (j = i; j <= rows_no; j++)
                    Console.Write(j + " ");

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            pattern(7);
            Console.ReadKey();
        }
    }
}
