using System;

namespace MultiDimesionalArray
{
    class Program
    {
        /// <summary>
        /// 3,3 ka size hai that means 0,1,2 agar <3 ki jgh equal to 3 kr diya to index out of bound error aa jaayega
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3]; //Declarion of 2D array
            arr[0, 1] = 10;
            arr[1, 2] = 20;
            arr[2, 0] = 30;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();//New line after each row
            }

        }
    }
}
